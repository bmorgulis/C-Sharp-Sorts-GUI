namespace SortVisualization2
{
    partial class Form1
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
            this.pnlMonitor = new System.Windows.Forms.Panel();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.pnlCount = new System.Windows.Forms.Panel();
            this.lblLoopCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnRadixSort = new System.Windows.Forms.Button();
            this.btnHeapSort = new System.Windows.Forms.Button();
            this.btnInsertionSort = new System.Windows.Forms.Button();
            this.pnlCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMonitor
            // 
            this.pnlMonitor.BackColor = System.Drawing.Color.White;
            this.pnlMonitor.Location = new System.Drawing.Point(13, 23);
            this.pnlMonitor.Name = "pnlMonitor";
            this.pnlMonitor.Size = new System.Drawing.Size(1500, 621);
            this.pnlMonitor.TabIndex = 0;
            this.pnlMonitor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMonitor_Paint);
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBubbleSort.Location = new System.Drawing.Point(1532, 221);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(273, 73);
            this.btnBubbleSort.TabIndex = 1;
            this.btnBubbleSort.Text = "Bubble sort";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // pnlCount
            // 
            this.pnlCount.BackColor = System.Drawing.Color.White;
            this.pnlCount.Controls.Add(this.lblLoopCount);
            this.pnlCount.Controls.Add(this.label1);
            this.pnlCount.Location = new System.Drawing.Point(1532, 26);
            this.pnlCount.Name = "pnlCount";
            this.pnlCount.Size = new System.Drawing.Size(273, 88);
            this.pnlCount.TabIndex = 2;
            // 
            // lblLoopCount
            // 
            this.lblLoopCount.AutoSize = true;
            this.lblLoopCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoopCount.Location = new System.Drawing.Point(98, 27);
            this.lblLoopCount.Name = "lblLoopCount";
            this.lblLoopCount.Size = new System.Drawing.Size(36, 37);
            this.lblLoopCount.TabIndex = 1;
            this.lblLoopCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loops";
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickSort.Location = new System.Drawing.Point(1532, 318);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(273, 73);
            this.btnQuickSort.TabIndex = 3;
            this.btnQuickSort.Text = "Quick sort";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(1532, 130);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(273, 73);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnRadixSort
            // 
            this.btnRadixSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRadixSort.Location = new System.Drawing.Point(1532, 416);
            this.btnRadixSort.Name = "btnRadixSort";
            this.btnRadixSort.Size = new System.Drawing.Size(273, 73);
            this.btnRadixSort.TabIndex = 5;
            this.btnRadixSort.Text = "Radix sort (No GUI)";
            this.btnRadixSort.UseVisualStyleBackColor = true;
            this.btnRadixSort.Click += new System.EventHandler(this.btnRadixSort_Click);
            // 
            // btnHeapSort
            // 
            this.btnHeapSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeapSort.Location = new System.Drawing.Point(1532, 514);
            this.btnHeapSort.Name = "btnHeapSort";
            this.btnHeapSort.Size = new System.Drawing.Size(273, 73);
            this.btnHeapSort.TabIndex = 6;
            this.btnHeapSort.Text = "Heap sort (No GUI)";
            this.btnHeapSort.UseVisualStyleBackColor = true;
            this.btnHeapSort.Click += new System.EventHandler(this.btnHeapSort_Click);
            // 
            // btnInsertionSort
            // 
            this.btnInsertionSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertionSort.Location = new System.Drawing.Point(1532, 613);
            this.btnInsertionSort.Name = "btnInsertionSort";
            this.btnInsertionSort.Size = new System.Drawing.Size(273, 73);
            this.btnInsertionSort.TabIndex = 7;
            this.btnInsertionSort.Text = "Insertion sort (No GUI)";
            this.btnInsertionSort.UseVisualStyleBackColor = true;
            this.btnInsertionSort.Click += new System.EventHandler(this.btnInsertionSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1814, 752);
            this.Controls.Add(this.btnInsertionSort);
            this.Controls.Add(this.btnHeapSort);
            this.Controls.Add(this.btnRadixSort);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.pnlCount);
            this.Controls.Add(this.btnBubbleSort);
            this.Controls.Add(this.pnlMonitor);
            this.Name = "Form1";
            this.Text = "Sort Visualization";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCount.ResumeLayout(false);
            this.pnlCount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMonitor;
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Panel pnlCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoopCount;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnRadixSort;
        private System.Windows.Forms.Button btnHeapSort;
        private System.Windows.Forms.Button btnInsertionSort;
    }
}

