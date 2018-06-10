namespace lab1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.countLabel1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_N1 = new System.Windows.Forms.TextBox();
            this.drawButtonDFT = new System.Windows.Forms.Button();
            this.reverseDFT_graph = new ZedGraph.ZedGraphControl();
            this.original_graph1 = new ZedGraph.ZedGraphControl();
            this.phaseDFT_graph = new ZedGraph.ZedGraphControl();
            this.absDFT_graph = new ZedGraph.ZedGraphControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.countLabel2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_N2 = new System.Windows.Forms.TextBox();
            this.drawButtonFFT = new System.Windows.Forms.Button();
            this.reverseFFT_graph = new ZedGraph.ZedGraphControl();
            this.original_graph2 = new ZedGraph.ZedGraphControl();
            this.phaseFFT_graph = new ZedGraph.ZedGraphControl();
            this.absFFT_graph = new ZedGraph.ZedGraphControl();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(908, 463);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(900, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ДПФ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.reverseDFT_graph, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.original_graph1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.phaseDFT_graph, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.absDFT_graph, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(894, 431);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.countLabel1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox_N1);
            this.panel1.Controls.Add(this.drawButtonDFT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 74);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Исходная функция: y = cos(2x) + sin(5x)";
            // 
            // countLabel1
            // 
            this.countLabel1.AutoSize = true;
            this.countLabel1.Location = new System.Drawing.Point(0, 58);
            this.countLabel1.Name = "countLabel1";
            this.countLabel1.Size = new System.Drawing.Size(0, 13);
            this.countLabel1.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Количество отсчётов, N";
            // 
            // textBox_N1
            // 
            this.textBox_N1.Location = new System.Drawing.Point(505, 33);
            this.textBox_N1.Name = "textBox_N1";
            this.textBox_N1.Size = new System.Drawing.Size(100, 20);
            this.textBox_N1.TabIndex = 21;
            this.textBox_N1.Text = "64";
            // 
            // drawButtonDFT
            // 
            this.drawButtonDFT.Location = new System.Drawing.Point(609, 25);
            this.drawButtonDFT.Name = "drawButtonDFT";
            this.drawButtonDFT.Size = new System.Drawing.Size(91, 30);
            this.drawButtonDFT.TabIndex = 18;
            this.drawButtonDFT.Text = "Draw";
            this.drawButtonDFT.UseVisualStyleBackColor = true;
            this.drawButtonDFT.Click += new System.EventHandler(this.drawButtonDFT_Click);
            // 
            // reverseDFT_graph
            // 
            this.reverseDFT_graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reverseDFT_graph.Location = new System.Drawing.Point(673, 85);
            this.reverseDFT_graph.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reverseDFT_graph.Name = "reverseDFT_graph";
            this.reverseDFT_graph.ScrollGrace = 0D;
            this.reverseDFT_graph.ScrollMaxX = 0D;
            this.reverseDFT_graph.ScrollMaxY = 0D;
            this.reverseDFT_graph.ScrollMaxY2 = 0D;
            this.reverseDFT_graph.ScrollMinX = 0D;
            this.reverseDFT_graph.ScrollMinY = 0D;
            this.reverseDFT_graph.ScrollMinY2 = 0D;
            this.reverseDFT_graph.Size = new System.Drawing.Size(217, 341);
            this.reverseDFT_graph.TabIndex = 17;
            this.reverseDFT_graph.ZoomButtons = System.Windows.Forms.MouseButtons.None;
            // 
            // original_graph1
            // 
            this.original_graph1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.original_graph1.Location = new System.Drawing.Point(4, 85);
            this.original_graph1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.original_graph1.Name = "original_graph1";
            this.original_graph1.ScrollGrace = 0D;
            this.original_graph1.ScrollMaxX = 0D;
            this.original_graph1.ScrollMaxY = 0D;
            this.original_graph1.ScrollMaxY2 = 0D;
            this.original_graph1.ScrollMinX = 0D;
            this.original_graph1.ScrollMinY = 0D;
            this.original_graph1.ScrollMinY2 = 0D;
            this.original_graph1.Size = new System.Drawing.Size(215, 341);
            this.original_graph1.TabIndex = 14;
            this.original_graph1.ZoomButtons = System.Windows.Forms.MouseButtons.None;
            // 
            // phaseDFT_graph
            // 
            this.phaseDFT_graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phaseDFT_graph.Location = new System.Drawing.Point(450, 85);
            this.phaseDFT_graph.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phaseDFT_graph.Name = "phaseDFT_graph";
            this.phaseDFT_graph.ScrollGrace = 0D;
            this.phaseDFT_graph.ScrollMaxX = 0D;
            this.phaseDFT_graph.ScrollMaxY = 0D;
            this.phaseDFT_graph.ScrollMaxY2 = 0D;
            this.phaseDFT_graph.ScrollMinX = 0D;
            this.phaseDFT_graph.ScrollMinY = 0D;
            this.phaseDFT_graph.ScrollMinY2 = 0D;
            this.phaseDFT_graph.Size = new System.Drawing.Size(215, 341);
            this.phaseDFT_graph.TabIndex = 16;
            this.phaseDFT_graph.ZoomButtons = System.Windows.Forms.MouseButtons.None;
            // 
            // absDFT_graph
            // 
            this.absDFT_graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.absDFT_graph.Location = new System.Drawing.Point(227, 85);
            this.absDFT_graph.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.absDFT_graph.Name = "absDFT_graph";
            this.absDFT_graph.ScrollGrace = 0D;
            this.absDFT_graph.ScrollMaxX = 0D;
            this.absDFT_graph.ScrollMaxY = 0D;
            this.absDFT_graph.ScrollMaxY2 = 0D;
            this.absDFT_graph.ScrollMinX = 0D;
            this.absDFT_graph.ScrollMinY = 0D;
            this.absDFT_graph.ScrollMinY2 = 0D;
            this.absDFT_graph.Size = new System.Drawing.Size(215, 341);
            this.absDFT_graph.TabIndex = 15;
            this.absDFT_graph.ZoomButtons = System.Windows.Forms.MouseButtons.None;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(900, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "БПФ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.reverseFFT_graph, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.original_graph2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.phaseFFT_graph, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.absFFT_graph, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(894, 431);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // panel2
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel2, 4);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.countLabel2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBox_N2);
            this.panel2.Controls.Add(this.drawButtonFFT);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(888, 74);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(5, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(356, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Исходная функция: y = cos(2x) + sin(5x)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // countLabel2
            // 
            this.countLabel2.AutoSize = true;
            this.countLabel2.Location = new System.Drawing.Point(6, 58);
            this.countLabel2.Name = "countLabel2";
            this.countLabel2.Size = new System.Drawing.Size(0, 13);
            this.countLabel2.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Количество отсчётов, N";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox_N2
            // 
            this.textBox_N2.Location = new System.Drawing.Point(516, 36);
            this.textBox_N2.Name = "textBox_N2";
            this.textBox_N2.Size = new System.Drawing.Size(100, 20);
            this.textBox_N2.TabIndex = 26;
            this.textBox_N2.Text = "64";
            // 
            // drawButtonFFT
            // 
            this.drawButtonFFT.Location = new System.Drawing.Point(620, 29);
            this.drawButtonFFT.Name = "drawButtonFFT";
            this.drawButtonFFT.Size = new System.Drawing.Size(91, 30);
            this.drawButtonFFT.TabIndex = 18;
            this.drawButtonFFT.Text = "Draw";
            this.drawButtonFFT.UseVisualStyleBackColor = true;
            this.drawButtonFFT.Click += new System.EventHandler(this.drawButtonFFT_Click);
            // 
            // reverseFFT_graph
            // 
            this.reverseFFT_graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reverseFFT_graph.Location = new System.Drawing.Point(673, 85);
            this.reverseFFT_graph.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reverseFFT_graph.Name = "reverseFFT_graph";
            this.reverseFFT_graph.ScrollGrace = 0D;
            this.reverseFFT_graph.ScrollMaxX = 0D;
            this.reverseFFT_graph.ScrollMaxY = 0D;
            this.reverseFFT_graph.ScrollMaxY2 = 0D;
            this.reverseFFT_graph.ScrollMinX = 0D;
            this.reverseFFT_graph.ScrollMinY = 0D;
            this.reverseFFT_graph.ScrollMinY2 = 0D;
            this.reverseFFT_graph.Size = new System.Drawing.Size(217, 341);
            this.reverseFFT_graph.TabIndex = 17;
            this.reverseFFT_graph.ZoomButtons = System.Windows.Forms.MouseButtons.None;
            this.reverseFFT_graph.Load += new System.EventHandler(this.reverseFFT_graph_Load);
            // 
            // original_graph2
            // 
            this.original_graph2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.original_graph2.Location = new System.Drawing.Point(4, 85);
            this.original_graph2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.original_graph2.Name = "original_graph2";
            this.original_graph2.ScrollGrace = 0D;
            this.original_graph2.ScrollMaxX = 0D;
            this.original_graph2.ScrollMaxY = 0D;
            this.original_graph2.ScrollMaxY2 = 0D;
            this.original_graph2.ScrollMinX = 0D;
            this.original_graph2.ScrollMinY = 0D;
            this.original_graph2.ScrollMinY2 = 0D;
            this.original_graph2.Size = new System.Drawing.Size(215, 341);
            this.original_graph2.TabIndex = 14;
            this.original_graph2.ZoomButtons = System.Windows.Forms.MouseButtons.None;
            // 
            // phaseFFT_graph
            // 
            this.phaseFFT_graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phaseFFT_graph.Location = new System.Drawing.Point(450, 85);
            this.phaseFFT_graph.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phaseFFT_graph.Name = "phaseFFT_graph";
            this.phaseFFT_graph.ScrollGrace = 0D;
            this.phaseFFT_graph.ScrollMaxX = 0D;
            this.phaseFFT_graph.ScrollMaxY = 0D;
            this.phaseFFT_graph.ScrollMaxY2 = 0D;
            this.phaseFFT_graph.ScrollMinX = 0D;
            this.phaseFFT_graph.ScrollMinY = 0D;
            this.phaseFFT_graph.ScrollMinY2 = 0D;
            this.phaseFFT_graph.Size = new System.Drawing.Size(215, 341);
            this.phaseFFT_graph.TabIndex = 16;
            this.phaseFFT_graph.ZoomButtons = System.Windows.Forms.MouseButtons.None;
            // 
            // absFFT_graph
            // 
            this.absFFT_graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.absFFT_graph.Location = new System.Drawing.Point(227, 85);
            this.absFFT_graph.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.absFFT_graph.Name = "absFFT_graph";
            this.absFFT_graph.ScrollGrace = 0D;
            this.absFFT_graph.ScrollMaxX = 0D;
            this.absFFT_graph.ScrollMaxY = 0D;
            this.absFFT_graph.ScrollMaxY2 = 0D;
            this.absFFT_graph.ScrollMinX = 0D;
            this.absFFT_graph.ScrollMinY = 0D;
            this.absFFT_graph.ScrollMinY2 = 0D;
            this.absFFT_graph.Size = new System.Drawing.Size(215, 341);
            this.absFFT_graph.TabIndex = 15;
            this.absFFT_graph.ZoomButtons = System.Windows.Forms.MouseButtons.None;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 463);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "ЛР1. Вариант 10. Дискретное преобразование фурье";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ZedGraph.ZedGraphControl reverseDFT_graph;
        private ZedGraph.ZedGraphControl phaseDFT_graph;
        private ZedGraph.ZedGraphControl absDFT_graph;
        private ZedGraph.ZedGraphControl original_graph1;
        private System.Windows.Forms.Button drawButtonDFT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button drawButtonFFT;
        private ZedGraph.ZedGraphControl reverseFFT_graph;
        private ZedGraph.ZedGraphControl original_graph2;
        private ZedGraph.ZedGraphControl phaseFFT_graph;
        private ZedGraph.ZedGraphControl absFFT_graph;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_N1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_N2;
        private System.Windows.Forms.Label countLabel1;
        private System.Windows.Forms.Label countLabel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}

