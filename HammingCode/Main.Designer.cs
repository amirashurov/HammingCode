namespace HammingCode
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Encode = new System.Windows.Forms.Button();
            this.txtFrame = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVerification = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numBadBit1 = new System.Windows.Forms.NumericUpDown();
            this.numBadBit2 = new System.Windows.Forms.NumericUpDown();
            this.Send = new System.Windows.Forms.Button();
            this.txtReceivedFrame = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Decode = new System.Windows.Forms.Button();
            this.txtCorrector = new System.Windows.Forms.TextBox();
            this.txtReceivedVerification = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Correct = new System.Windows.Forms.Button();
            this.txtReceivedMessage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GenerateRandomCode = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.numMsgLength = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numBadBit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBadBit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMsgLength)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 74);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(270, 20);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Информационная часть кода";
            // 
            // Encode
            // 
            this.Encode.Location = new System.Drawing.Point(288, 71);
            this.Encode.Name = "Encode";
            this.Encode.Size = new System.Drawing.Size(136, 23);
            this.Encode.TabIndex = 2;
            this.Encode.Text = "Кодировать";
            this.Encode.UseVisualStyleBackColor = true;
            this.Encode.Click += new System.EventHandler(this.Encode_Click);
            // 
            // txtFrame
            // 
            this.txtFrame.Location = new System.Drawing.Point(12, 123);
            this.txtFrame.Name = "txtFrame";
            this.txtFrame.Size = new System.Drawing.Size(270, 20);
            this.txtFrame.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Избыточная комбинация\t";
            // 
            // txtVerification
            // 
            this.txtVerification.Location = new System.Drawing.Point(288, 123);
            this.txtVerification.Name = "txtVerification";
            this.txtVerification.Size = new System.Drawing.Size(136, 20);
            this.txtVerification.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "E";
            // 
            // numBadBit1
            // 
            this.numBadBit1.Location = new System.Drawing.Point(12, 177);
            this.numBadBit1.Name = "numBadBit1";
            this.numBadBit1.Size = new System.Drawing.Size(45, 20);
            this.numBadBit1.TabIndex = 3;
            // 
            // numBadBit2
            // 
            this.numBadBit2.Location = new System.Drawing.Point(73, 177);
            this.numBadBit2.Name = "numBadBit2";
            this.numBadBit2.Size = new System.Drawing.Size(45, 20);
            this.numBadBit2.TabIndex = 3;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(288, 174);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(136, 23);
            this.Send.TabIndex = 2;
            this.Send.Text = "Передать";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // txtReceivedFrame
            // 
            this.txtReceivedFrame.Location = new System.Drawing.Point(12, 231);
            this.txtReceivedFrame.Name = "txtReceivedFrame";
            this.txtReceivedFrame.Size = new System.Drawing.Size(270, 20);
            this.txtReceivedFrame.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "label1";
            // 
            // Decode
            // 
            this.Decode.Location = new System.Drawing.Point(288, 228);
            this.Decode.Name = "Decode";
            this.Decode.Size = new System.Drawing.Size(136, 23);
            this.Decode.TabIndex = 2;
            this.Decode.Text = "Декодировать";
            this.Decode.UseVisualStyleBackColor = true;
            this.Decode.Click += new System.EventHandler(this.Decode_Click);
            // 
            // txtCorrector
            // 
            this.txtCorrector.Location = new System.Drawing.Point(12, 298);
            this.txtCorrector.Name = "txtCorrector";
            this.txtCorrector.Size = new System.Drawing.Size(270, 20);
            this.txtCorrector.TabIndex = 0;
            // 
            // txtReceivedVerification
            // 
            this.txtReceivedVerification.Location = new System.Drawing.Point(288, 298);
            this.txtReceivedVerification.Name = "txtReceivedVerification";
            this.txtReceivedVerification.Size = new System.Drawing.Size(136, 20);
            this.txtReceivedVerification.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Корректор";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "K";
            // 
            // Correct
            // 
            this.Correct.Location = new System.Drawing.Point(288, 338);
            this.Correct.Name = "Correct";
            this.Correct.Size = new System.Drawing.Size(136, 23);
            this.Correct.TabIndex = 2;
            this.Correct.Text = "Исправить";
            this.Correct.UseVisualStyleBackColor = true;
            this.Correct.Click += new System.EventHandler(this.Correct_Click);
            // 
            // txtReceivedMessage
            // 
            this.txtReceivedMessage.Location = new System.Drawing.Point(12, 414);
            this.txtReceivedMessage.Name = "txtReceivedMessage";
            this.txtReceivedMessage.Size = new System.Drawing.Size(270, 20);
            this.txtReceivedMessage.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Исправленная комбинация";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(288, 411);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(136, 23);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Принятая комбинация";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Номера искаженных разрядов";
            // 
            // GenerateRandomCode
            // 
            this.GenerateRandomCode.Location = new System.Drawing.Point(288, 27);
            this.GenerateRandomCode.Name = "GenerateRandomCode";
            this.GenerateRandomCode.Size = new System.Drawing.Size(136, 23);
            this.GenerateRandomCode.TabIndex = 2;
            this.GenerateRandomCode.Text = "Генерировать";
            this.GenerateRandomCode.UseVisualStyleBackColor = true;
            this.GenerateRandomCode.Click += new System.EventHandler(this.GenerateRandomCode_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Длина Инфо часть кода";
            // 
            // numMsgLength
            // 
            this.numMsgLength.Location = new System.Drawing.Point(208, 30);
            this.numMsgLength.Name = "numMsgLength";
            this.numMsgLength.Size = new System.Drawing.Size(62, 20);
            this.numMsgLength.TabIndex = 4;
            this.numMsgLength.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 464);
            this.Controls.Add(this.numMsgLength);
            this.Controls.Add(this.numBadBit2);
            this.Controls.Add(this.numBadBit1);
            this.Controls.Add(this.Correct);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Decode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.GenerateRandomCode);
            this.Controls.Add(this.Encode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtReceivedVerification);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCorrector);
            this.Controls.Add(this.txtVerification);
            this.Controls.Add(this.txtFrame);
            this.Controls.Add(this.txtReceivedMessage);
            this.Controls.Add(this.txtReceivedFrame);
            this.Controls.Add(this.txtMessage);
            this.Name = "Form1";
            this.Text = "Иллюстрация кода Хэмминга";
            ((System.ComponentModel.ISupportInitialize)(this.numBadBit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBadBit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMsgLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Encode;
        private System.Windows.Forms.TextBox txtFrame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVerification;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numBadBit1;
        private System.Windows.Forms.NumericUpDown numBadBit2;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox txtReceivedFrame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Decode;
        private System.Windows.Forms.TextBox txtCorrector;
        private System.Windows.Forms.TextBox txtReceivedVerification;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Correct;
        private System.Windows.Forms.TextBox txtReceivedMessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button GenerateRandomCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numMsgLength;
    }
}

