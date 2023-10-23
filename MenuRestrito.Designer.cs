namespace OtimizaçãoCésar
{
    partial class MenuRestrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuRestrito));
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox2 = new GroupBox();
            button11 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            groupBox3 = new GroupBox();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button10 = new Button();
            groupBox4 = new GroupBox();
            button15 = new Button();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            label9 = new Label();
            groupBox5 = new GroupBox();
            button16 = new Button();
            opNao = new RadioButton();
            opSim = new RadioButton();
            groupBox6 = new GroupBox();
            button20 = new Button();
            button19 = new Button();
            button18 = new Button();
            button17 = new Button();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(-13, -48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(291, 228);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(283, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 175);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Otimizações Superficiais (Tem que ser feito toda hora)";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button6
            // 
            button6.Location = new Point(178, 114);
            button6.Name = "button6";
            button6.Size = new Size(153, 33);
            button6.TabIndex = 5;
            button6.Text = "Excluir Pasta Downloads";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(178, 75);
            button5.Name = "button5";
            button5.Size = new Size(153, 33);
            button5.TabIndex = 4;
            button5.Text = "Desfragmentar (HD)";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(24, 75);
            button4.Name = "button4";
            button4.Size = new Size(129, 33);
            button4.TabIndex = 3;
            button4.Text = "Esvaziar a prefetch";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.AutoEllipsis = true;
            button3.Location = new Point(24, 114);
            button3.Name = "button3";
            button3.Size = new Size(129, 33);
            button3.TabIndex = 2;
            button3.Text = "Esvaziar a Lixeira";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(178, 36);
            button2.Name = "button2";
            button2.Size = new Size(153, 33);
            button2.TabIndex = 1;
            button2.Text = "Limpar a %temp%";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(24, 35);
            button1.Name = "button1";
            button1.Size = new Size(129, 33);
            button1.TabIndex = 0;
            button1.Tag = "teste";
            button1.Text = "Limpar a \"Temp\"";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button11);
            groupBox2.Controls.Add(button9);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button7);
            groupBox2.Location = new Point(289, 186);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(148, 191);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tweak's de Otimização";
            // 
            // button11
            // 
            button11.Location = new Point(20, 147);
            button11.Name = "button11";
            button11.Size = new Size(109, 24);
            button11.TabIndex = 3;
            button11.Text = "Plano de Energia";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(20, 109);
            button9.Name = "button9";
            button9.Size = new Size(109, 23);
            button9.TabIndex = 2;
            button9.Text = "Desabilitar Updates";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(20, 70);
            button8.Name = "button8";
            button8.Size = new Size(109, 23);
            button8.TabIndex = 1;
            button8.Text = "Diminuir Latência";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(20, 32);
            button7.Name = "button7";
            button7.Size = new Size(109, 23);
            button7.TabIndex = 0;
            button7.Text = "Boost Windows";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(richTextBox1);
            groupBox3.Location = new Point(6, 186);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(277, 398);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "O que somos?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 381);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 21;
            label1.Text = "v0.3";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.White;
            richTextBox1.Location = new Point(0, 22);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(265, 327);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(289, 393);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(207, 191);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(502, 393);
            label2.Name = "label2";
            label2.Size = new Size(132, 15);
            label2.TabIndex = 8;
            label2.Text = "César Rodrigues Ribeiro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(502, 419);
            label3.Name = "label3";
            label3.Size = new Size(402, 15);
            label3.TabIndex = 9;
            label3.Text = "- Tecnólogo em Desenvolvimento de Software Multiplataforma pela FATEC.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(502, 434);
            label4.Name = "label4";
            label4.Size = new Size(415, 30);
            label4.TabIndex = 10;
            label4.Text = "- Técnico não finalizado de Análise e Desenvolvimento de Software pela ETEC.\r\n\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(502, 449);
            label5.Name = "label5";
            label5.Size = new Size(168, 15);
            label5.TabIndex = 11;
            label5.Text = "- Inglês Intermediário pela Fisk";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(502, 464);
            label6.Name = "label6";
            label6.Size = new Size(183, 15);
            label6.TabIndex = 12;
            label6.Text = "- Curso I.O.T pela Cisco Academy";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(506, 488);
            label7.Name = "label7";
            label7.Size = new Size(108, 15);
            label7.TabIndex = 13;
            label7.Text = "@Zuqqt no GitHub";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(502, 516);
            label8.Name = "label8";
            label8.Size = new Size(168, 15);
            label8.TabIndex = 14;
            label8.Text = "Cursando DSM (2/6) na FATEC.";
            // 
            // button10
            // 
            button10.Location = new Point(827, 547);
            button10.Name = "button10";
            button10.Size = new Size(90, 32);
            button10.TabIndex = 15;
            button10.Text = "Fechar";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button15);
            groupBox4.Controls.Add(button14);
            groupBox4.Controls.Add(button13);
            groupBox4.Controls.Add(button12);
            groupBox4.Location = new Point(443, 186);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(213, 191);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ajudam também:";
            // 
            // button15
            // 
            button15.Location = new Point(11, 147);
            button15.Name = "button15";
            button15.Size = new Size(196, 23);
            button15.TabIndex = 3;
            button15.Text = "Desativar serviços não essenciais:";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button14
            // 
            button14.Location = new Point(11, 109);
            button14.Name = "button14";
            button14.Size = new Size(196, 23);
            button14.TabIndex = 2;
            button14.Text = "Desativar efeitos visuais:";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button13
            // 
            button13.Location = new Point(11, 70);
            button13.Name = "button13";
            button13.Size = new Size(196, 23);
            button13.TabIndex = 1;
            button13.Text = "Desativar Indexação de Arquivo";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click_1;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button12.Location = new Point(11, 32);
            button12.Name = "button12";
            button12.Size = new Size(196, 23);
            button12.TabIndex = 0;
            button12.Text = "Desativar Notificações Windows";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(52, 39);
            label9.Name = "label9";
            label9.Size = new Size(143, 45);
            label9.TabIndex = 18;
            label9.Text = "Vocês acham\r\n que esse projeto terá \r\nimpacto na sua máquina?";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label9.Click += label9_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button16);
            groupBox5.Controls.Add(opNao);
            groupBox5.Controls.Add(opSim);
            groupBox5.Controls.Add(label9);
            groupBox5.Location = new Point(662, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(255, 175);
            groupBox5.TabIndex = 19;
            groupBox5.TabStop = false;
            groupBox5.Text = "Pequena questão";
            // 
            // button16
            // 
            button16.Location = new Point(120, 114);
            button16.Name = "button16";
            button16.Size = new Size(75, 23);
            button16.TabIndex = 21;
            button16.Text = "Enviar";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // opNao
            // 
            opNao.AutoSize = true;
            opNao.Location = new Point(39, 128);
            opNao.Name = "opNao";
            opNao.Size = new Size(47, 19);
            opNao.TabIndex = 20;
            opNao.TabStop = true;
            opNao.Text = "Não";
            opNao.UseVisualStyleBackColor = true;
            opNao.CheckedChanged += opNao_CheckedChanged;
            // 
            // opSim
            // 
            opSim.AutoSize = true;
            opSim.Location = new Point(39, 103);
            opSim.Name = "opSim";
            opSim.Size = new Size(45, 19);
            opSim.TabIndex = 19;
            opSim.TabStop = true;
            opSim.Text = "Sim";
            opSim.TextAlign = ContentAlignment.MiddleCenter;
            opSim.UseVisualStyleBackColor = true;
            opSim.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(button20);
            groupBox6.Controls.Add(button19);
            groupBox6.Controls.Add(button18);
            groupBox6.Controls.Add(button17);
            groupBox6.Location = new Point(664, 186);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(253, 191);
            groupBox6.TabIndex = 20;
            groupBox6.TabStop = false;
            groupBox6.Text = "Extras:";
            // 
            // button20
            // 
            button20.Location = new Point(21, 147);
            button20.Name = "button20";
            button20.Size = new Size(208, 23);
            button20.TabIndex = 3;
            button20.Text = "Ir ao Gerenciador de Tarefas";
            button20.UseVisualStyleBackColor = true;
            button20.Click += button20_Click;
            // 
            // button19
            // 
            button19.Location = new Point(21, 109);
            button19.Name = "button19";
            button19.Size = new Size(208, 23);
            button19.TabIndex = 2;
            button19.Text = "Painel de Controle";
            button19.UseVisualStyleBackColor = true;
            button19.Click += button19_Click;
            // 
            // button18
            // 
            button18.Location = new Point(21, 70);
            button18.Name = "button18";
            button18.Size = new Size(208, 23);
            button18.TabIndex = 1;
            button18.Text = "Desativar atualizações do Windows";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click_1;
            // 
            // button17
            // 
            button17.Location = new Point(21, 32);
            button17.Name = "button17";
            button17.Size = new Size(208, 23);
            button17.TabIndex = 0;
            button17.Text = "Excluir atualizações do Windows";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(502, 563);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(155, 15);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Aqui você vê meu currículo.";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // MenuRestrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 587);
            Controls.Add(linkLabel1);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(button10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuRestrito";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Otimização SharkBoost by César Rodrigues (@Zuqqt)";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button6;
        private Button button5;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RichTextBox richTextBox1;
        private Button button9;
        private Button button8;
        private Button button7;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button10;
        private GroupBox groupBox4;
        private Button button11;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Label label9;
        private GroupBox groupBox5;
        private RadioButton opNao;
        private RadioButton opSim;
        private Button button16;
        private GroupBox groupBox6;
        private Button button17;
        private LinkLabel linkLabel1;
        private Button button18;
        private Button button19;
        private Button button20;
        private Label label1;
    }
}