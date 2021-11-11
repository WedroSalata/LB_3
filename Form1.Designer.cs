
namespace LB_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btDraw = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.tb1side1 = new System.Windows.Forms.TextBox();
            this.tbY1 = new System.Windows.Forms.TextBox();
            this.tb1side2 = new System.Windows.Forms.TextBox();
            this.tbX1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.gbZagSt = new System.Windows.Forms.GroupBox();
            this.cbColor1 = new System.Windows.Forms.ComboBox();
            this.cbType1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btClearBoard = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btRemoveSelected = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btSaveParams = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tbX2 = new System.Windows.Forms.TextBox();
            this.tbY2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbZagOp = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tb2side2 = new System.Windows.Forms.TextBox();
            this.tb2side1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lSearchResult = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbSelectSearch = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btRemove = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.cbType2 = new System.Windows.Forms.ComboBox();
            this.cbColor2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbZagSt.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.gbZagOp.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btDraw
            // 
            this.btDraw.Location = new System.Drawing.Point(6, 513);
            this.btDraw.Name = "btDraw";
            this.btDraw.Size = new System.Drawing.Size(99, 30);
            this.btDraw.TabIndex = 1;
            this.btDraw.Text = "Намалювати";
            this.btDraw.UseVisualStyleBackColor = true;
            this.btDraw.Click += new System.EventHandler(this.btDraw_Click);
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(6, 139);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(502, 390);
            this.pb1.TabIndex = 2;
            this.pb1.TabStop = false;
            // 
            // tb1side1
            // 
            this.tb1side1.Location = new System.Drawing.Point(88, 15);
            this.tb1side1.Name = "tb1side1";
            this.tb1side1.Size = new System.Drawing.Size(100, 22);
            this.tb1side1.TabIndex = 3;
            // 
            // tbY1
            // 
            this.tbY1.Location = new System.Drawing.Point(25, 49);
            this.tbY1.Name = "tbY1";
            this.tbY1.Size = new System.Drawing.Size(100, 22);
            this.tbY1.TabIndex = 5;
            // 
            // tb1side2
            // 
            this.tb1side2.Location = new System.Drawing.Point(88, 46);
            this.tb1side2.Name = "tb1side2";
            this.tb1side2.Size = new System.Drawing.Size(100, 22);
            this.tb1side2.TabIndex = 6;
            // 
            // tbX1
            // 
            this.tbX1.Location = new System.Drawing.Point(25, 21);
            this.tbX1.Name = "tbX1";
            this.tbX1.Size = new System.Drawing.Size(100, 22);
            this.tbX1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.gbZagSt);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.pb1);
            this.groupBox1.Controls.Add(this.btClearBoard);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 543);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Створення объектів";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(6, 103);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(312, 30);
            this.btAdd.TabIndex = 28;
            this.btAdd.Text = "Створити";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // gbZagSt
            // 
            this.gbZagSt.Controls.Add(this.cbColor1);
            this.gbZagSt.Controls.Add(this.cbType1);
            this.gbZagSt.Controls.Add(this.label2);
            this.gbZagSt.Controls.Add(this.label9);
            this.gbZagSt.Location = new System.Drawing.Point(6, 21);
            this.gbZagSt.Name = "gbZagSt";
            this.gbZagSt.Size = new System.Drawing.Size(170, 76);
            this.gbZagSt.TabIndex = 27;
            this.gbZagSt.TabStop = false;
            this.gbZagSt.Text = "Загальні параметри";
            // 
            // cbColor1
            // 
            this.cbColor1.FormattingEnabled = true;
            this.cbColor1.Items.AddRange(new object[] {
            "0 - Чёрный",
            "1 - Зелёный",
            "2 - Красный",
            "3 - Синий"});
            this.cbColor1.Location = new System.Drawing.Point(63, 48);
            this.cbColor1.Name = "cbColor1";
            this.cbColor1.Size = new System.Drawing.Size(100, 24);
            this.cbColor1.TabIndex = 40;
            // 
            // cbType1
            // 
            this.cbType1.FormattingEnabled = true;
            this.cbType1.Items.AddRange(new object[] {
            "0 - Прямоугольник",
            "1 - Круг",
            "2 - Шестиугольник"});
            this.cbType1.Location = new System.Drawing.Point(63, 21);
            this.cbType1.Name = "cbType1";
            this.cbType1.Size = new System.Drawing.Size(100, 24);
            this.cbType1.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Колір";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Тип";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbX1);
            this.groupBox4.Controls.Add(this.tbY1);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(182, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(132, 76);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Кординати";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "У";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "X";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb1side2);
            this.groupBox3.Controls.Add(this.tb1side1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(320, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 76);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Розмір";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Сторона 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Сторона 2";
            // 
            // btClearBoard
            // 
            this.btClearBoard.Location = new System.Drawing.Point(324, 103);
            this.btClearBoard.Name = "btClearBoard";
            this.btClearBoard.Size = new System.Drawing.Size(184, 30);
            this.btClearBoard.TabIndex = 16;
            this.btClearBoard.Text = "Очистити дошку";
            this.btClearBoard.UseVisualStyleBackColor = true;
            this.btClearBoard.Click += new System.EventHandler(this.btClearBoard_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btRemoveSelected);
            this.groupBox2.Controls.Add(this.lb1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.groupBox10);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.btDraw);
            this.groupBox2.Location = new System.Drawing.Point(562, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 550);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Оперування коллекцією";
            // 
            // btRemoveSelected
            // 
            this.btRemoveSelected.Location = new System.Drawing.Point(106, 513);
            this.btRemoveSelected.Name = "btRemoveSelected";
            this.btRemoveSelected.Size = new System.Drawing.Size(151, 30);
            this.btRemoveSelected.TabIndex = 33;
            this.btRemoveSelected.Text = "Видалити вибраний елемент";
            this.btRemoveSelected.UseVisualStyleBackColor = true;
            this.btRemoveSelected.Click += new System.EventHandler(this.btRemoveSelected_Click);
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.ItemHeight = 16;
            this.lb1.Location = new System.Drawing.Point(6, 39);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(251, 468);
            this.lb1.TabIndex = 32;
            this.lb1.SelectedIndexChanged += new System.EventHandler(this.lb1_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Список елементів";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btSaveParams);
            this.groupBox10.Controls.Add(this.groupBox8);
            this.groupBox10.Controls.Add(this.gbZagOp);
            this.groupBox10.Controls.Add(this.groupBox9);
            this.groupBox10.Location = new System.Drawing.Point(266, 21);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(200, 301);
            this.groupBox10.TabIndex = 31;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Поля об\'єкта";
            // 
            // btSaveParams
            // 
            this.btSaveParams.Location = new System.Drawing.Point(18, 267);
            this.btSaveParams.Name = "btSaveParams";
            this.btSaveParams.Size = new System.Drawing.Size(158, 29);
            this.btSaveParams.TabIndex = 32;
            this.btSaveParams.Text = "Зберегти параметри";
            this.btSaveParams.UseVisualStyleBackColor = true;
            this.btSaveParams.Click += new System.EventHandler(this.btSaveParams_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tbX2);
            this.groupBox8.Controls.Add(this.tbY2);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Location = new System.Drawing.Point(6, 21);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(194, 71);
            this.groupBox8.TabIndex = 29;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Кординати";
            // 
            // tbX2
            // 
            this.tbX2.Location = new System.Drawing.Point(88, 21);
            this.tbX2.Name = "tbX2";
            this.tbX2.Size = new System.Drawing.Size(100, 22);
            this.tbX2.TabIndex = 7;
            // 
            // tbY2
            // 
            this.tbY2.Location = new System.Drawing.Point(88, 46);
            this.tbY2.Name = "tbY2";
            this.tbY2.Size = new System.Drawing.Size(100, 22);
            this.tbY2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "У";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "X";
            // 
            // gbZagOp
            // 
            this.gbZagOp.Controls.Add(this.cbColor2);
            this.gbZagOp.Controls.Add(this.cbType2);
            this.gbZagOp.Controls.Add(this.label1);
            this.gbZagOp.Controls.Add(this.label3);
            this.gbZagOp.Location = new System.Drawing.Point(6, 180);
            this.gbZagOp.Name = "gbZagOp";
            this.gbZagOp.Size = new System.Drawing.Size(194, 76);
            this.gbZagOp.TabIndex = 30;
            this.gbZagOp.TabStop = false;
            this.gbZagOp.Text = "Загальні параметри";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Колір";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Тип";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.tb2side2);
            this.groupBox9.Controls.Add(this.tb2side1);
            this.groupBox9.Controls.Add(this.label11);
            this.groupBox9.Controls.Add(this.label12);
            this.groupBox9.Location = new System.Drawing.Point(6, 98);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(194, 76);
            this.groupBox9.TabIndex = 28;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Розмір";
            // 
            // tb2side2
            // 
            this.tb2side2.Location = new System.Drawing.Point(88, 46);
            this.tb2side2.Name = "tb2side2";
            this.tb2side2.Size = new System.Drawing.Size(100, 22);
            this.tb2side2.TabIndex = 6;
            // 
            // tb2side1
            // 
            this.tb2side1.Location = new System.Drawing.Point(88, 15);
            this.tb2side1.Name = "tb2side1";
            this.tb2side1.Size = new System.Drawing.Size(100, 22);
            this.tb2side1.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Сторона 1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Сторона 2";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.lSearchResult);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.cbSelectSearch);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.tbSearch);
            this.groupBox6.Controls.Add(this.btRemove);
            this.groupBox6.Controls.Add(this.btSearch);
            this.groupBox6.Location = new System.Drawing.Point(266, 323);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 214);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Пошук елемента";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 17);
            this.label16.TabIndex = 38;
            this.label16.Text = "Результат пошуку";
            // 
            // lSearchResult
            // 
            this.lSearchResult.AutoSize = true;
            this.lSearchResult.Location = new System.Drawing.Point(6, 82);
            this.lSearchResult.Name = "lSearchResult";
            this.lSearchResult.Size = new System.Drawing.Size(185, 17);
            this.lSearchResult.TabIndex = 37;
            this.lSearchResult.Text = "|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 17);
            this.label15.TabIndex = 36;
            this.label15.Text = "Критерій пошуку";
            // 
            // cbSelectSearch
            // 
            this.cbSelectSearch.FormattingEnabled = true;
            this.cbSelectSearch.Items.AddRange(new object[] {
            "Тип",
            "Х",
            "У",
            "Сторона 1",
            "Сторона 2",
            "Колір"});
            this.cbSelectSearch.Location = new System.Drawing.Point(11, 38);
            this.cbSelectSearch.Name = "cbSelectSearch";
            this.cbSelectSearch.Size = new System.Drawing.Size(182, 24);
            this.cbSelectSearch.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 17);
            this.label14.TabIndex = 25;
            this.label14.Text = "Пошук";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(6, 149);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(182, 22);
            this.tbSearch.TabIndex = 20;
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(113, 177);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(81, 29);
            this.btRemove.TabIndex = 33;
            this.btRemove.Text = "Видалити";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(6, 177);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(82, 29);
            this.btSearch.TabIndex = 17;
            this.btSearch.Text = "Знайти";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // cbType2
            // 
            this.cbType2.FormattingEnabled = true;
            this.cbType2.Items.AddRange(new object[] {
            "0 - Прямоугольник",
            "1 - Круг",
            "2 - Шестиугольник"});
            this.cbType2.Location = new System.Drawing.Point(88, 21);
            this.cbType2.Name = "cbType2";
            this.cbType2.Size = new System.Drawing.Size(100, 24);
            this.cbType2.TabIndex = 40;
            // 
            // cbColor2
            // 
            this.cbColor2.FormattingEnabled = true;
            this.cbColor2.Items.AddRange(new object[] {
            "0 - Чёрный",
            "1 - Зелёный",
            "2 - Красный",
            "3 - Синий"});
            this.cbColor2.Location = new System.Drawing.Point(88, 46);
            this.cbColor2.Name = "cbColor2";
            this.cbColor2.Size = new System.Drawing.Size(100, 24);
            this.cbColor2.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 559);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Лабораторна робота 3";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.gbZagSt.ResumeLayout(false);
            this.gbZagSt.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.gbZagOp.ResumeLayout(false);
            this.gbZagOp.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btDraw;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.TextBox tb1side1;
        private System.Windows.Forms.TextBox tbY1;
        private System.Windows.Forms.TextBox tb1side2;
        private System.Windows.Forms.TextBox tbX1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbZagSt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btClearBoard;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btSaveParams;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox tbX2;
        private System.Windows.Forms.TextBox tbY2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbZagOp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox tb2side2;
        private System.Windows.Forms.TextBox tb2side1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRemoveSelected;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbSelectSearch;
        private System.Windows.Forms.Label lSearchResult;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbType1;
        private System.Windows.Forms.ComboBox cbColor1;
        private System.Windows.Forms.ComboBox cbType2;
        private System.Windows.Forms.ComboBox cbColor2;
    }
}

