namespace RandomGenerator
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbRepeat1 = new System.Windows.Forms.CheckBox();
            this.tbOutput1 = new System.Windows.Forms.TextBox();
            this.btnGenerate1 = new System.Windows.Forms.Button();
            this.tbNumberOfElements1 = new System.Windows.Forms.TextBox();
            this.lbNumberOfElements1 = new System.Windows.Forms.Label();
            this.tbMax1 = new System.Windows.Forms.TextBox();
            this.lbMax1 = new System.Windows.Forms.Label();
            this.lbMin1 = new System.Windows.Forms.Label();
            this.tbMin1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbRepeat2 = new System.Windows.Forms.CheckBox();
            this.tbOutput2 = new System.Windows.Forms.TextBox();
            this.btnGenerate2 = new System.Windows.Forms.Button();
            this.tbNumberOfElements2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMax2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMin2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chbRepeat3 = new System.Windows.Forms.CheckBox();
            this.tbOutput3 = new System.Windows.Forms.TextBox();
            this.btnGenerate3 = new System.Windows.Forms.Button();
            this.tbNumberOfElements3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMax3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMin3 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbEditLbItem = new System.Windows.Forms.TextBox();
            this.btnPaste = new System.Windows.Forms.Button();
            this.lbNumStudents = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnGenerateAll = new System.Windows.Forms.Button();
            this.btnAllCopy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbRepeat1);
            this.groupBox1.Controls.Add(this.tbOutput1);
            this.groupBox1.Controls.Add(this.btnGenerate1);
            this.groupBox1.Controls.Add(this.tbNumberOfElements1);
            this.groupBox1.Controls.Add(this.lbNumberOfElements1);
            this.groupBox1.Controls.Add(this.tbMax1);
            this.groupBox1.Controls.Add(this.lbMax1);
            this.groupBox1.Controls.Add(this.lbMin1);
            this.groupBox1.Controls.Add(this.tbMin1);
            this.groupBox1.Location = new System.Drawing.Point(13, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 537);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вопрос 1";
            // 
            // chbRepeat1
            // 
            this.chbRepeat1.AutoSize = true;
            this.chbRepeat1.Location = new System.Drawing.Point(18, 65);
            this.chbRepeat1.Name = "chbRepeat1";
            this.chbRepeat1.Size = new System.Drawing.Size(103, 17);
            this.chbRepeat1.TabIndex = 17;
            this.chbRepeat1.Text = "Повторы чисел";
            this.chbRepeat1.UseVisualStyleBackColor = true;
            // 
            // tbOutput1
            // 
            this.tbOutput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutput1.Location = new System.Drawing.Point(13, 93);
            this.tbOutput1.Multiline = true;
            this.tbOutput1.Name = "tbOutput1";
            this.tbOutput1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput1.Size = new System.Drawing.Size(280, 438);
            this.tbOutput1.TabIndex = 16;
            // 
            // btnGenerate1
            // 
            this.btnGenerate1.Location = new System.Drawing.Point(135, 39);
            this.btnGenerate1.Name = "btnGenerate1";
            this.btnGenerate1.Size = new System.Drawing.Size(95, 23);
            this.btnGenerate1.TabIndex = 15;
            this.btnGenerate1.Text = "Гененрировать";
            this.btnGenerate1.UseVisualStyleBackColor = true;
            this.btnGenerate1.Click += new System.EventHandler(this.btnGenerate1_Click);
            // 
            // tbNumberOfElements1
            // 
            this.tbNumberOfElements1.Location = new System.Drawing.Point(242, 13);
            this.tbNumberOfElements1.Name = "tbNumberOfElements1";
            this.tbNumberOfElements1.Size = new System.Drawing.Size(49, 20);
            this.tbNumberOfElements1.TabIndex = 14;
            this.tbNumberOfElements1.Text = "14";
            // 
            // lbNumberOfElements1
            // 
            this.lbNumberOfElements1.AutoSize = true;
            this.lbNumberOfElements1.Location = new System.Drawing.Point(138, 16);
            this.lbNumberOfElements1.Name = "lbNumberOfElements1";
            this.lbNumberOfElements1.Size = new System.Drawing.Size(98, 13);
            this.lbNumberOfElements1.TabIndex = 13;
            this.lbNumberOfElements1.Text = "Количество чисел";
            // 
            // tbMax1
            // 
            this.tbMax1.Location = new System.Drawing.Point(76, 39);
            this.tbMax1.Name = "tbMax1";
            this.tbMax1.Size = new System.Drawing.Size(42, 20);
            this.tbMax1.TabIndex = 12;
            this.tbMax1.Text = "25";
            // 
            // lbMax1
            // 
            this.lbMax1.AutoSize = true;
            this.lbMax1.Location = new System.Drawing.Point(15, 42);
            this.lbMax1.Name = "lbMax1";
            this.lbMax1.Size = new System.Drawing.Size(61, 13);
            this.lbMax1.TabIndex = 11;
            this.lbMax1.Text = "Максимум";
            // 
            // lbMin1
            // 
            this.lbMin1.AutoSize = true;
            this.lbMin1.Location = new System.Drawing.Point(15, 16);
            this.lbMin1.Name = "lbMin1";
            this.lbMin1.Size = new System.Drawing.Size(55, 13);
            this.lbMin1.TabIndex = 10;
            this.lbMin1.Text = "Минимум";
            // 
            // tbMin1
            // 
            this.tbMin1.Location = new System.Drawing.Point(76, 13);
            this.tbMin1.Name = "tbMin1";
            this.tbMin1.Size = new System.Drawing.Size(42, 20);
            this.tbMin1.TabIndex = 9;
            this.tbMin1.Text = "1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbRepeat2);
            this.groupBox2.Controls.Add(this.tbOutput2);
            this.groupBox2.Controls.Add(this.btnGenerate2);
            this.groupBox2.Controls.Add(this.tbNumberOfElements2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbMax2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbMin2);
            this.groupBox2.Location = new System.Drawing.Point(326, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 537);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вопрос 2";
            // 
            // chbRepeat2
            // 
            this.chbRepeat2.AutoSize = true;
            this.chbRepeat2.Location = new System.Drawing.Point(18, 65);
            this.chbRepeat2.Name = "chbRepeat2";
            this.chbRepeat2.Size = new System.Drawing.Size(103, 17);
            this.chbRepeat2.TabIndex = 17;
            this.chbRepeat2.Text = "Повторы чисел";
            this.chbRepeat2.UseVisualStyleBackColor = true;
            // 
            // tbOutput2
            // 
            this.tbOutput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutput2.Location = new System.Drawing.Point(13, 93);
            this.tbOutput2.Multiline = true;
            this.tbOutput2.Name = "tbOutput2";
            this.tbOutput2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput2.Size = new System.Drawing.Size(280, 438);
            this.tbOutput2.TabIndex = 16;
            // 
            // btnGenerate2
            // 
            this.btnGenerate2.Location = new System.Drawing.Point(135, 39);
            this.btnGenerate2.Name = "btnGenerate2";
            this.btnGenerate2.Size = new System.Drawing.Size(95, 23);
            this.btnGenerate2.TabIndex = 15;
            this.btnGenerate2.Text = "Гененрировать";
            this.btnGenerate2.UseVisualStyleBackColor = true;
            this.btnGenerate2.Click += new System.EventHandler(this.btnGenerate2_Click);
            // 
            // tbNumberOfElements2
            // 
            this.tbNumberOfElements2.Location = new System.Drawing.Point(242, 13);
            this.tbNumberOfElements2.Name = "tbNumberOfElements2";
            this.tbNumberOfElements2.Size = new System.Drawing.Size(49, 20);
            this.tbNumberOfElements2.TabIndex = 14;
            this.tbNumberOfElements2.Text = "14";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Количество чисел";
            // 
            // tbMax2
            // 
            this.tbMax2.Location = new System.Drawing.Point(76, 39);
            this.tbMax2.Name = "tbMax2";
            this.tbMax2.Size = new System.Drawing.Size(42, 20);
            this.tbMax2.TabIndex = 12;
            this.tbMax2.Text = "25";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Максимум";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Минимум";
            // 
            // tbMin2
            // 
            this.tbMin2.Location = new System.Drawing.Point(76, 13);
            this.tbMin2.Name = "tbMin2";
            this.tbMin2.Size = new System.Drawing.Size(42, 20);
            this.tbMin2.TabIndex = 9;
            this.tbMin2.Text = "1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chbRepeat3);
            this.groupBox3.Controls.Add(this.tbOutput3);
            this.groupBox3.Controls.Add(this.btnGenerate3);
            this.groupBox3.Controls.Add(this.tbNumberOfElements3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbMax3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbMin3);
            this.groupBox3.Location = new System.Drawing.Point(639, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 537);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вопрос 3";
            // 
            // chbRepeat3
            // 
            this.chbRepeat3.AutoSize = true;
            this.chbRepeat3.Location = new System.Drawing.Point(18, 65);
            this.chbRepeat3.Name = "chbRepeat3";
            this.chbRepeat3.Size = new System.Drawing.Size(103, 17);
            this.chbRepeat3.TabIndex = 17;
            this.chbRepeat3.Text = "Повторы чисел";
            this.chbRepeat3.UseVisualStyleBackColor = true;
            // 
            // tbOutput3
            // 
            this.tbOutput3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutput3.Location = new System.Drawing.Point(13, 93);
            this.tbOutput3.Multiline = true;
            this.tbOutput3.Name = "tbOutput3";
            this.tbOutput3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput3.Size = new System.Drawing.Size(280, 438);
            this.tbOutput3.TabIndex = 16;
            // 
            // btnGenerate3
            // 
            this.btnGenerate3.Location = new System.Drawing.Point(135, 39);
            this.btnGenerate3.Name = "btnGenerate3";
            this.btnGenerate3.Size = new System.Drawing.Size(95, 23);
            this.btnGenerate3.TabIndex = 15;
            this.btnGenerate3.Text = "Гененрировать";
            this.btnGenerate3.UseVisualStyleBackColor = true;
            this.btnGenerate3.Click += new System.EventHandler(this.btnGenerate3_Click);
            // 
            // tbNumberOfElements3
            // 
            this.tbNumberOfElements3.Location = new System.Drawing.Point(242, 13);
            this.tbNumberOfElements3.Name = "tbNumberOfElements3";
            this.tbNumberOfElements3.Size = new System.Drawing.Size(49, 20);
            this.tbNumberOfElements3.TabIndex = 14;
            this.tbNumberOfElements3.Text = "14";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Количество чисел";
            // 
            // tbMax3
            // 
            this.tbMax3.Location = new System.Drawing.Point(76, 39);
            this.tbMax3.Name = "tbMax3";
            this.tbMax3.Size = new System.Drawing.Size(42, 20);
            this.tbMax3.TabIndex = 12;
            this.tbMax3.Text = "25";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Максимум";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Минимум";
            // 
            // tbMin3
            // 
            this.tbMin3.Location = new System.Drawing.Point(76, 13);
            this.tbMin3.Name = "tbMin3";
            this.tbMin3.Size = new System.Drawing.Size(42, 20);
            this.tbMin3.TabIndex = 9;
            this.tbMin3.Text = "1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(10, 10);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1248, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbEditLbItem);
            this.groupBox4.Controls.Add(this.btnPaste);
            this.groupBox4.Controls.Add(this.lbNumStudents);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.listBoxStudents);
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.btnOpenFile);
            this.groupBox4.Location = new System.Drawing.Point(952, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(307, 537);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Список";
            // 
            // tbEditLbItem
            // 
            this.tbEditLbItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbEditLbItem.Location = new System.Drawing.Point(13, 175);
            this.tbEditLbItem.Name = "tbEditLbItem";
            this.tbEditLbItem.Size = new System.Drawing.Size(288, 29);
            this.tbEditLbItem.TabIndex = 22;
            this.tbEditLbItem.Visible = false;
            this.tbEditLbItem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbEditLbItem_KeyUp);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(117, 48);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(75, 23);
            this.btnPaste.TabIndex = 21;
            this.btnPaste.Text = "Вставить";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // lbNumStudents
            // 
            this.lbNumStudents.AutoSize = true;
            this.lbNumStudents.Location = new System.Drawing.Point(236, 24);
            this.lbNumStudents.Name = "lbNumStudents";
            this.lbNumStudents.Size = new System.Drawing.Size(35, 13);
            this.lbNumStudents.TabIndex = 20;
            this.lbNumStudents.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Количество человек: ";
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.ContextMenuStrip = this.contextMenuStrip1;
            this.listBoxStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.ItemHeight = 24;
            this.listBoxStudents.Location = new System.Drawing.Point(6, 93);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(282, 436);
            this.listBoxStudents.TabIndex = 18;
            this.listBoxStudents.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxStudents_MouseClick);
            this.listBoxStudents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            this.listBoxStudents.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxStudents_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAdd,
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // ToolStripMenuItemAdd
            // 
            this.ToolStripMenuItemAdd.Name = "ToolStripMenuItemAdd";
            this.ToolStripMenuItemAdd.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemAdd.Text = "Добавить";
            this.ToolStripMenuItemAdd.Click += new System.EventHandler(this.ToolStripMenuItemAdd_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Удалить";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(13, 48);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(13, 19);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(95, 23);
            this.btnOpenFile.TabIndex = 15;
            this.btnOpenFile.Text = "Открыть";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGenerateAll
            // 
            this.btnGenerateAll.Location = new System.Drawing.Point(13, 580);
            this.btnGenerateAll.Name = "btnGenerateAll";
            this.btnGenerateAll.Size = new System.Drawing.Size(1246, 23);
            this.btnGenerateAll.TabIndex = 5;
            this.btnGenerateAll.Text = "Генерировать для всех";
            this.btnGenerateAll.UseVisualStyleBackColor = true;
            this.btnGenerateAll.Click += new System.EventHandler(this.btnGenerateAll_Click);
            // 
            // btnAllCopy
            // 
            this.btnAllCopy.Location = new System.Drawing.Point(13, 609);
            this.btnAllCopy.Name = "btnAllCopy";
            this.btnAllCopy.Size = new System.Drawing.Size(1246, 23);
            this.btnAllCopy.TabIndex = 6;
            this.btnAllCopy.Text = "Копировать для всех";
            this.btnAllCopy.UseVisualStyleBackColor = true;
            this.btnAllCopy.Click += new System.EventHandler(this.btnAllCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 645);
            this.Controls.Add(this.btnAllCopy);
            this.Controls.Add(this.btnGenerateAll);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Generator TSA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbRepeat1;
        private System.Windows.Forms.TextBox tbOutput1;
        private System.Windows.Forms.Button btnGenerate1;
        private System.Windows.Forms.TextBox tbNumberOfElements1;
        private System.Windows.Forms.Label lbNumberOfElements1;
        private System.Windows.Forms.TextBox tbMax1;
        private System.Windows.Forms.Label lbMax1;
        private System.Windows.Forms.Label lbMin1;
        private System.Windows.Forms.TextBox tbMin1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbRepeat2;
        private System.Windows.Forms.TextBox tbOutput2;
        private System.Windows.Forms.Button btnGenerate2;
        private System.Windows.Forms.TextBox tbNumberOfElements2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMax2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMin2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chbRepeat3;
        private System.Windows.Forms.TextBox tbOutput3;
        private System.Windows.Forms.Button btnGenerate3;
        private System.Windows.Forms.TextBox tbNumberOfElements3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMax3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMin3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.Label lbNumStudents;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGenerateAll;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnAllCopy;
        private System.Windows.Forms.TextBox tbEditLbItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAdd;
    }
}

