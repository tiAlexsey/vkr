namespace vkr
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartF = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartKSi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelSigma = new System.Windows.Forms.Label();
            this.labelTau = new System.Windows.Forms.Label();
            this.groupBoxLine = new System.Windows.Forms.GroupBox();
            this.checkBoxLineClear = new System.Windows.Forms.CheckBox();
            this.labelLine = new System.Windows.Forms.Label();
            this.textBoxSizeLine = new System.Windows.Forms.TextBox();
            this.groupBoxAxisY = new System.Windows.Forms.GroupBox();
            this.labelYMaxN = new System.Windows.Forms.Label();
            this.labelYmaxKSi = new System.Windows.Forms.Label();
            this.labelYMaxF = new System.Windows.Forms.Label();
            this.labelYMaxD = new System.Windows.Forms.Label();
            this.labelYMaxA = new System.Windows.Forms.Label();
            this.textBoxYMaxN = new System.Windows.Forms.TextBox();
            this.textBoxYMaxKSi = new System.Windows.Forms.TextBox();
            this.textBoxYMaxF = new System.Windows.Forms.TextBox();
            this.textBoxYMaxD = new System.Windows.Forms.TextBox();
            this.textBoxYMaxA = new System.Windows.Forms.TextBox();
            this.groupBoxParam = new System.Windows.Forms.GroupBox();
            this.labelTV = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.labelT = new System.Windows.Forms.Label();
            this.labelDelta = new System.Windows.Forms.Label();
            this.labelMu = new System.Windows.Forms.Label();
            this.labelLya = new System.Windows.Forms.Label();
            this.textBoxTV = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.textBoxDelta = new System.Windows.Forms.TextBox();
            this.textBoxMu = new System.Windows.Forms.TextBox();
            this.textBoxLya = new System.Windows.Forms.TextBox();
            this.buttonExec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKSi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartN)).BeginInit();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxLine.SuspendLayout();
            this.groupBoxAxisY.SuspendLayout();
            this.groupBoxParam.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartA.ChartAreas.Add(chartArea1);
            this.chartA.Location = new System.Drawing.Point(0, 0);
            this.chartA.Name = "chartA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chartA.Series.Add(series1);
            this.chartA.Size = new System.Drawing.Size(400, 200);
            this.chartA.TabIndex = 0;
            title1.Name = "TitleA";
            title1.Text = "Входящий поток заявок (A)";
            this.chartA.Titles.Add(title1);
            // 
            // chartD
            // 
            chartArea2.Name = "ChartArea1";
            this.chartD.ChartAreas.Add(chartArea2);
            this.chartD.Location = new System.Drawing.Point(0, 200);
            this.chartD.Name = "chartD";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series1";
            this.chartD.Series.Add(series2);
            this.chartD.Size = new System.Drawing.Size(400, 200);
            this.chartD.TabIndex = 1;
            title2.Name = "TitleD";
            title2.Text = "Поток обслуженных заявок (D)";
            this.chartD.Titles.Add(title2);
            // 
            // chartF
            // 
            chartArea3.Name = "ChartArea1";
            this.chartF.ChartAreas.Add(chartArea3);
            this.chartF.Location = new System.Drawing.Point(0, 400);
            this.chartF.Name = "chartF";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "Series1";
            this.chartF.Series.Add(series3);
            this.chartF.Size = new System.Drawing.Size(400, 200);
            this.chartF.TabIndex = 2;
            title3.Name = "TitleF";
            title3.Text = "Поток ушедших заявок (F)";
            this.chartF.Titles.Add(title3);
            // 
            // chartKSi
            // 
            chartArea4.Name = "ChartArea1";
            this.chartKSi.ChartAreas.Add(chartArea4);
            this.chartKSi.Location = new System.Drawing.Point(400, 0);
            this.chartKSi.Name = "chartKSi";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Name = "Series1";
            this.chartKSi.Series.Add(series4);
            this.chartKSi.Size = new System.Drawing.Size(400, 200);
            this.chartKSi.TabIndex = 3;
            title4.Name = "TitleKSi";
            title4.Text = "Кол-во заявок в системе (KSi)";
            this.chartKSi.Titles.Add(title4);
            // 
            // chartN
            // 
            chartArea5.Name = "ChartArea1";
            this.chartN.ChartAreas.Add(chartArea5);
            this.chartN.Location = new System.Drawing.Point(400, 200);
            this.chartN.Name = "chartN";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Name = "Series1";
            this.chartN.Series.Add(series5);
            this.chartN.Size = new System.Drawing.Size(400, 200);
            this.chartN.TabIndex = 4;
            title5.Name = "TitleN";
            title5.Text = "Кол-во обрабатывающих приборов (n)";
            this.chartN.Titles.Add(title5);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.label13);
            this.groupBoxInfo.Controls.Add(this.labelSum);
            this.groupBoxInfo.Controls.Add(this.label14);
            this.groupBoxInfo.Controls.Add(this.label16);
            this.groupBoxInfo.Controls.Add(this.labelSigma);
            this.groupBoxInfo.Controls.Add(this.labelTau);
            this.groupBoxInfo.Location = new System.Drawing.Point(400, 400);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(400, 200);
            this.groupBoxInfo.TabIndex = 26;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Информация";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(320, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Момент времени, фиксирующий заявку, попавшую в очередь";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(12, 158);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(0, 13);
            this.labelSum.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(264, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Максимальное время ожидания заявки в очереди";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 135);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(375, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Момент времени, когда заявка должна уйти, не дождавшись обработки";
            // 
            // labelSigma
            // 
            this.labelSigma.AutoSize = true;
            this.labelSigma.Location = new System.Drawing.Point(12, 47);
            this.labelSigma.Name = "labelSigma";
            this.labelSigma.Size = new System.Drawing.Size(0, 13);
            this.labelSigma.TabIndex = 11;
            // 
            // labelTau
            // 
            this.labelTau.AutoSize = true;
            this.labelTau.Location = new System.Drawing.Point(12, 100);
            this.labelTau.Name = "labelTau";
            this.labelTau.Size = new System.Drawing.Size(0, 13);
            this.labelTau.TabIndex = 12;
            // 
            // groupBoxLine
            // 
            this.groupBoxLine.Controls.Add(this.checkBoxLineClear);
            this.groupBoxLine.Controls.Add(this.labelLine);
            this.groupBoxLine.Controls.Add(this.textBoxSizeLine);
            this.groupBoxLine.Location = new System.Drawing.Point(810, 297);
            this.groupBoxLine.Name = "groupBoxLine";
            this.groupBoxLine.Size = new System.Drawing.Size(225, 68);
            this.groupBoxLine.TabIndex = 24;
            this.groupBoxLine.TabStop = false;
            this.groupBoxLine.Text = "Настройка отрисовки линии";
            // 
            // checkBoxLineClear
            // 
            this.checkBoxLineClear.AutoSize = true;
            this.checkBoxLineClear.Checked = true;
            this.checkBoxLineClear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLineClear.Location = new System.Drawing.Point(13, 43);
            this.checkBoxLineClear.Name = "checkBoxLineClear";
            this.checkBoxLineClear.Size = new System.Drawing.Size(167, 17);
            this.checkBoxLineClear.TabIndex = 12;
            this.checkBoxLineClear.Text = "Очистка предыдущих линий";
            this.checkBoxLineClear.UseVisualStyleBackColor = true;
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.Location = new System.Drawing.Point(8, 20);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(142, 13);
            this.labelLine.TabIndex = 10;
            this.labelLine.Text = "Толщина линии отрисовки";
            // 
            // textBoxSizeLine
            // 
            this.textBoxSizeLine.Location = new System.Drawing.Point(156, 17);
            this.textBoxSizeLine.Name = "textBoxSizeLine";
            this.textBoxSizeLine.Size = new System.Drawing.Size(50, 20);
            this.textBoxSizeLine.TabIndex = 11;
            this.textBoxSizeLine.Text = "2";
            // 
            // groupBoxAxisY
            // 
            this.groupBoxAxisY.Controls.Add(this.labelYMaxN);
            this.groupBoxAxisY.Controls.Add(this.labelYmaxKSi);
            this.groupBoxAxisY.Controls.Add(this.labelYMaxF);
            this.groupBoxAxisY.Controls.Add(this.labelYMaxD);
            this.groupBoxAxisY.Controls.Add(this.labelYMaxA);
            this.groupBoxAxisY.Controls.Add(this.textBoxYMaxN);
            this.groupBoxAxisY.Controls.Add(this.textBoxYMaxKSi);
            this.groupBoxAxisY.Controls.Add(this.textBoxYMaxF);
            this.groupBoxAxisY.Controls.Add(this.textBoxYMaxD);
            this.groupBoxAxisY.Controls.Add(this.textBoxYMaxA);
            this.groupBoxAxisY.Location = new System.Drawing.Point(810, 191);
            this.groupBoxAxisY.Name = "groupBoxAxisY";
            this.groupBoxAxisY.Size = new System.Drawing.Size(225, 100);
            this.groupBoxAxisY.TabIndex = 23;
            this.groupBoxAxisY.TabStop = false;
            this.groupBoxAxisY.Text = "Настройка осей Y";
            // 
            // labelYMaxN
            // 
            this.labelYMaxN.AutoSize = true;
            this.labelYMaxN.Location = new System.Drawing.Point(114, 50);
            this.labelYMaxN.Name = "labelYMaxN";
            this.labelYMaxN.Size = new System.Drawing.Size(42, 13);
            this.labelYMaxN.TabIndex = 15;
            this.labelYMaxN.Text = "Ymax n";
            // 
            // labelYmaxKSi
            // 
            this.labelYmaxKSi.AutoSize = true;
            this.labelYmaxKSi.Location = new System.Drawing.Point(108, 24);
            this.labelYmaxKSi.Name = "labelYmaxKSi";
            this.labelYmaxKSi.Size = new System.Drawing.Size(50, 13);
            this.labelYmaxKSi.TabIndex = 14;
            this.labelYmaxKSi.Text = "Ymax Ksi";
            // 
            // labelYMaxF
            // 
            this.labelYMaxF.AutoSize = true;
            this.labelYMaxF.Location = new System.Drawing.Point(6, 76);
            this.labelYMaxF.Name = "labelYMaxF";
            this.labelYMaxF.Size = new System.Drawing.Size(42, 13);
            this.labelYMaxF.TabIndex = 13;
            this.labelYMaxF.Text = "Ymax F";
            // 
            // labelYMaxD
            // 
            this.labelYMaxD.AutoSize = true;
            this.labelYMaxD.Location = new System.Drawing.Point(6, 50);
            this.labelYMaxD.Name = "labelYMaxD";
            this.labelYMaxD.Size = new System.Drawing.Size(44, 13);
            this.labelYMaxD.TabIndex = 12;
            this.labelYMaxD.Text = "Ymax D";
            // 
            // labelYMaxA
            // 
            this.labelYMaxA.AutoSize = true;
            this.labelYMaxA.Location = new System.Drawing.Point(6, 24);
            this.labelYMaxA.Name = "labelYMaxA";
            this.labelYMaxA.Size = new System.Drawing.Size(43, 13);
            this.labelYMaxA.TabIndex = 11;
            this.labelYMaxA.Text = "Ymax A";
            // 
            // textBoxYMaxN
            // 
            this.textBoxYMaxN.Location = new System.Drawing.Point(162, 47);
            this.textBoxYMaxN.Name = "textBoxYMaxN";
            this.textBoxYMaxN.Size = new System.Drawing.Size(50, 20);
            this.textBoxYMaxN.TabIndex = 10;
            this.textBoxYMaxN.Text = "5";
            // 
            // textBoxYMaxKSi
            // 
            this.textBoxYMaxKSi.Location = new System.Drawing.Point(162, 21);
            this.textBoxYMaxKSi.Name = "textBoxYMaxKSi";
            this.textBoxYMaxKSi.Size = new System.Drawing.Size(50, 20);
            this.textBoxYMaxKSi.TabIndex = 9;
            this.textBoxYMaxKSi.Text = "5";
            // 
            // textBoxYMaxF
            // 
            this.textBoxYMaxF.Location = new System.Drawing.Point(54, 73);
            this.textBoxYMaxF.Name = "textBoxYMaxF";
            this.textBoxYMaxF.Size = new System.Drawing.Size(50, 20);
            this.textBoxYMaxF.TabIndex = 8;
            this.textBoxYMaxF.Text = "5";
            // 
            // textBoxYMaxD
            // 
            this.textBoxYMaxD.Location = new System.Drawing.Point(55, 47);
            this.textBoxYMaxD.Name = "textBoxYMaxD";
            this.textBoxYMaxD.Size = new System.Drawing.Size(50, 20);
            this.textBoxYMaxD.TabIndex = 7;
            this.textBoxYMaxD.Text = "5";
            // 
            // textBoxYMaxA
            // 
            this.textBoxYMaxA.Location = new System.Drawing.Point(55, 21);
            this.textBoxYMaxA.Name = "textBoxYMaxA";
            this.textBoxYMaxA.Size = new System.Drawing.Size(50, 20);
            this.textBoxYMaxA.TabIndex = 6;
            this.textBoxYMaxA.Text = "5";
            // 
            // groupBoxParam
            // 
            this.groupBoxParam.Controls.Add(this.labelTV);
            this.groupBoxParam.Controls.Add(this.labelN);
            this.groupBoxParam.Controls.Add(this.labelT);
            this.groupBoxParam.Controls.Add(this.labelDelta);
            this.groupBoxParam.Controls.Add(this.labelMu);
            this.groupBoxParam.Controls.Add(this.labelLya);
            this.groupBoxParam.Controls.Add(this.textBoxTV);
            this.groupBoxParam.Controls.Add(this.textBoxN);
            this.groupBoxParam.Controls.Add(this.textBoxT);
            this.groupBoxParam.Controls.Add(this.textBoxDelta);
            this.groupBoxParam.Controls.Add(this.textBoxMu);
            this.groupBoxParam.Controls.Add(this.textBoxLya);
            this.groupBoxParam.Location = new System.Drawing.Point(810, 7);
            this.groupBoxParam.Name = "groupBoxParam";
            this.groupBoxParam.Size = new System.Drawing.Size(225, 178);
            this.groupBoxParam.TabIndex = 22;
            this.groupBoxParam.TabStop = false;
            this.groupBoxParam.Text = "Параметры";
            // 
            // labelTV
            // 
            this.labelTV.AutoSize = true;
            this.labelTV.Location = new System.Drawing.Point(6, 152);
            this.labelTV.Name = "labelTV";
            this.labelTV.Size = new System.Drawing.Size(153, 13);
            this.labelTV.TabIndex = 11;
            this.labelTV.Text = "Мак. вр. ожид. в очереди (tV)";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(6, 126);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(152, 13);
            this.labelN.TabIndex = 10;
            this.labelN.Text = "Кол-во обслуж. приборов (N)";
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Location = new System.Drawing.Point(6, 100);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(139, 13);
            this.labelT.TabIndex = 9;
            this.labelT.Text = "Время моделирования (T)";
            // 
            // labelDelta
            // 
            this.labelDelta.AutoSize = true;
            this.labelDelta.Location = new System.Drawing.Point(6, 74);
            this.labelDelta.Name = "labelDelta";
            this.labelDelta.Size = new System.Drawing.Size(106, 13);
            this.labelDelta.TabIndex = 8;
            this.labelDelta.Text = "Шаг времени (delta)";
            // 
            // labelMu
            // 
            this.labelMu.AutoSize = true;
            this.labelMu.Location = new System.Drawing.Point(6, 48);
            this.labelMu.Name = "labelMu";
            this.labelMu.Size = new System.Drawing.Size(153, 13);
            this.labelMu.TabIndex = 7;
            this.labelMu.Text = "Интенc. обслуж. заявок (Mu)";
            // 
            // labelLya
            // 
            this.labelLya.AutoSize = true;
            this.labelLya.Location = new System.Drawing.Point(6, 22);
            this.labelLya.Name = "labelLya";
            this.labelLya.Size = new System.Drawing.Size(152, 13);
            this.labelLya.TabIndex = 6;
            this.labelLya.Text = "Интенc. поступ. заявок (Lya)";
            // 
            // textBoxTV
            // 
            this.textBoxTV.Location = new System.Drawing.Point(169, 149);
            this.textBoxTV.Name = "textBoxTV";
            this.textBoxTV.Size = new System.Drawing.Size(50, 20);
            this.textBoxTV.TabIndex = 5;
            this.textBoxTV.Text = "2";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(169, 123);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(50, 20);
            this.textBoxN.TabIndex = 4;
            this.textBoxN.Text = "2";
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(169, 97);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(50, 20);
            this.textBoxT.TabIndex = 3;
            this.textBoxT.Text = "10";
            // 
            // textBoxDelta
            // 
            this.textBoxDelta.Location = new System.Drawing.Point(169, 71);
            this.textBoxDelta.Name = "textBoxDelta";
            this.textBoxDelta.Size = new System.Drawing.Size(50, 20);
            this.textBoxDelta.TabIndex = 2;
            this.textBoxDelta.Text = "0,1";
            // 
            // textBoxMu
            // 
            this.textBoxMu.Location = new System.Drawing.Point(169, 45);
            this.textBoxMu.Name = "textBoxMu";
            this.textBoxMu.Size = new System.Drawing.Size(50, 20);
            this.textBoxMu.TabIndex = 1;
            this.textBoxMu.Text = "0,3";
            // 
            // textBoxLya
            // 
            this.textBoxLya.Location = new System.Drawing.Point(169, 19);
            this.textBoxLya.Name = "textBoxLya";
            this.textBoxLya.Size = new System.Drawing.Size(50, 20);
            this.textBoxLya.TabIndex = 0;
            this.textBoxLya.Text = "0,5";
            // 
            // buttonExec
            // 
            this.buttonExec.Location = new System.Drawing.Point(880, 435);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(88, 23);
            this.buttonExec.TabIndex = 25;
            this.buttonExec.Text = "Построить";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.ButtonExec_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 606);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.groupBoxLine);
            this.Controls.Add(this.groupBoxAxisY);
            this.Controls.Add(this.groupBoxParam);
            this.Controls.Add(this.buttonExec);
            this.Controls.Add(this.chartN);
            this.Controls.Add(this.chartKSi);
            this.Controls.Add(this.chartF);
            this.Controls.Add(this.chartD);
            this.Controls.Add(this.chartA);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Модель системы с произвольным временем ожидания \'нетерпиливых\' заявок";
            ((System.ComponentModel.ISupportInitialize)(this.chartA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKSi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartN)).EndInit();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxLine.ResumeLayout(false);
            this.groupBoxLine.PerformLayout();
            this.groupBoxAxisY.ResumeLayout(false);
            this.groupBoxAxisY.PerformLayout();
            this.groupBoxParam.ResumeLayout(false);
            this.groupBoxParam.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartF;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKSi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartN;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelSigma;
        private System.Windows.Forms.Label labelTau;
        private System.Windows.Forms.GroupBox groupBoxLine;
        private System.Windows.Forms.CheckBox checkBoxLineClear;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.TextBox textBoxSizeLine;
        private System.Windows.Forms.GroupBox groupBoxAxisY;
        private System.Windows.Forms.Label labelYMaxN;
        private System.Windows.Forms.Label labelYmaxKSi;
        private System.Windows.Forms.Label labelYMaxF;
        private System.Windows.Forms.Label labelYMaxD;
        private System.Windows.Forms.Label labelYMaxA;
        private System.Windows.Forms.TextBox textBoxYMaxN;
        private System.Windows.Forms.TextBox textBoxYMaxKSi;
        private System.Windows.Forms.TextBox textBoxYMaxF;
        private System.Windows.Forms.TextBox textBoxYMaxD;
        private System.Windows.Forms.TextBox textBoxYMaxA;
        private System.Windows.Forms.GroupBox groupBoxParam;
        private System.Windows.Forms.Label labelTV;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.Label labelDelta;
        private System.Windows.Forms.Label labelMu;
        private System.Windows.Forms.Label labelLya;
        private System.Windows.Forms.TextBox textBoxTV;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.TextBox textBoxDelta;
        private System.Windows.Forms.TextBox textBoxMu;
        private System.Windows.Forms.TextBox textBoxLya;
        private System.Windows.Forms.Button buttonExec;
    }
}