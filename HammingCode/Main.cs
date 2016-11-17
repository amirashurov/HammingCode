using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HammingCode.Properties;

namespace HammingCode
{
    public partial class Main : Form
    {
        Binary _message;
        private int _columnsAmount = 0;
        private int _rowsAmount = 0;//(int) Math.Ceiling(Math.Log(columnsAmount, 2) + 1);
        private BinaryMatrix _binaryHMatrix;
        private Binary _verification;
        private Binary _frame;
        private Binary _receivedVerification;
        private Binary _receivedMessage;
        private Binary _receivedFrame;
        private BinaryMatrix _binaryReceivedHMatrix;
        private Binary _receivedMessageVerification;
        private Binary _corrector;
        private Random _random;

        public Main()
        {
            InitializeComponent();
            
        }

        private void Encode_Click(object sender, EventArgs e)
        {
            _binaryHMatrix = GenerateHMatrix(_rowsAmount, _columnsAmount);
            _verification = GenerateVerificationBits(_binaryHMatrix, _message);
            _frame = Binary.Concatenate(_message, _verification);
            txtFrame.Text = _frame.ToString();
            txtVerification.Text = _verification.ToString();
        }

        

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            _message = new Binary(txtMessage.Text.Select(c => c == '1'));
            _columnsAmount = _message.Count();
            _rowsAmount = (int) Math.Ceiling(Math.Log(_columnsAmount, 2) + 1);
        }

        private void Send_Click(object sender, EventArgs e)
        {
            _receivedFrame = new Binary(_frame.ToArray());
            int badBit = (int) numBadBit1.Value - 1;
            int badBit2 = (int) numBadBit2.Value - 1;

            if (badBit > -1)
            {
                _receivedFrame[badBit] = !_receivedFrame[badBit];
            }
            if (badBit2 > -1)
            {
                _receivedFrame[badBit2] = !_receivedFrame[badBit2];
            }

            txtReceivedFrame.Text = _receivedFrame.ToString();
            
        }

        private void Decode_Click(object sender, EventArgs e)
        {
            _receivedMessage = new Binary(_receivedFrame.Take(_columnsAmount));     
            _receivedVerification = new Binary(_receivedFrame.Skip(_columnsAmount));

            _binaryReceivedHMatrix = GenerateHMatrix(_rowsAmount, _columnsAmount);
            _receivedMessageVerification = GenerateVerificationBits(_binaryReceivedHMatrix, _receivedMessage);
            _corrector = _receivedVerification ^ _receivedMessageVerification;

            txtCorrector.Text = _corrector.ToString();
            txtReceivedVerification.Text = _receivedMessageVerification.ToString();


        }

        private void Correct_Click(object sender, EventArgs e)
        {
            if(_corrector.CountOnes()>0)
            {
                try
                {
                    BinaryMatrix HWithIdentity = GenerateHWithIdentity(_binaryReceivedHMatrix);
                    int faultyBitPosition = FindFaultyBit(HWithIdentity, _corrector);
                    
                    Binary correctedFrame = new Binary(_receivedFrame.ToArray());
                    correctedFrame[faultyBitPosition] = !correctedFrame[faultyBitPosition];

                    Binary correctedFrameGeneratedVerify = GenerateVerificationBits(_binaryReceivedHMatrix, new Binary(correctedFrame.Take(_columnsAmount)));
                    Binary correctedFrameVerify = new Binary(correctedFrame.Skip(_columnsAmount));
                    Binary correctionVerify = correctedFrameVerify ^ correctedFrameGeneratedVerify;
                    if (correctionVerify.CountOnes() == 0)
                        //Console.WriteLine("Corrected frame = {0}", correctedFrame);
                        txtReceivedMessage.Text = correctedFrame.ToString();
                    else
                        MessageBox.Show(Resources.FrameUncorrectable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Resources.FrameUncorrectable);
                }
            }
            else
            {
                txtReceivedMessage.Text = _receivedFrame.ToString();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerateRandomCode_Click(object sender, EventArgs e)
        {
            _random = new Random(DateTime.Now.Millisecond);
            String message = Enumerable.Range(0, (int) numMsgLength.Value).Aggregate("", (current, i) => current + _random.Next(0, 100) % 2);
            txtMessage.Text = message;
            txtMessage_TextChanged(sender, e);
        }

        #region Hamming
        static int FindFaultyBit(BinaryMatrix H, Binary s)
        {
            for (int i = 0; i < H.ColumnAmount; i++)
            {
                Binary column = H.GetColumn(i);
                Binary check = s ^ column;
                if(check.Any(b=>b))
                    continue;
                return i;
            }

            throw new WarningException("Faulty bit not found!");
        }

        BinaryMatrix GenerateHWithIdentity(BinaryMatrix H)
        {
            BinaryMatrix HWithIdentity = new BinaryMatrix(H.RowAmount, H.ColumnAmount + H.RowAmount);
            for (int y = 0; y < H.RowAmount; y++)
            {
                for (int x = 0; x < H.ColumnAmount; x++)
                {
                    HWithIdentity.Set(y, x, H.Get(y, x));
                }
            }

            for (int y = 0; y < H.RowAmount; y++)
            {
                int n = 0;
                for (int x = H.ColumnAmount; x < H.ColumnAmount + H.RowAmount; x++)
                {
                    HWithIdentity.Set(y, x, y == n);

                    n++;
                }
            }
            return HWithIdentity;
        }
        
        Binary GenerateVerificationBits(BinaryMatrix H, Binary message)
        {
            Binary verification = new Binary(new bool[H.RowAmount]);
            for (int i = 0; i < H.RowAmount; i++)
            {
                Binary row = H.GetRow(i);
                Binary addiction = row & message;
                bool verificationBit = addiction.CountOnes()%2 == 1;
                verification[i] = verificationBit;
            }
            return verification;
        }

        BinaryMatrix GenerateHMatrix (int rowsAmount, int columnsAmount)
        {
            BinaryMatrix H = new BinaryMatrix(rowsAmount, columnsAmount);

            int column = 0;
            for (int i = 1; i <= Math.Pow(2, rowsAmount); i++)
            {
                Binary binary = new Binary(i, H.RowAmount);
                if (binary.CountOnes() >= 2)
                {
                    for (int row = 0; row < rowsAmount; row++)
                    {
                        H.Set(row, column, binary[row]);
                    }
                    column++;
                }
                if (column >= H.ColumnAmount)
                    break;
            }
            return H;
        }
        #endregion
    }


}
