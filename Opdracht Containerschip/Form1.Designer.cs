namespace Opdracht_Containerschip
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
            this.listBoxContainersInput = new System.Windows.Forms.ListBox();
            this.radioButtonContainer = new System.Windows.Forms.RadioButton();
            this.radioButtonCooledContainer = new System.Windows.Forms.RadioButton();
            this.radioButtonValuableContainer = new System.Windows.Forms.RadioButton();
            this.radioButtonCooledValuableContainer = new System.Windows.Forms.RadioButton();
            this.buttonAddContainer = new System.Windows.Forms.Button();
            this.labelContainerWeight = new System.Windows.Forms.Label();
            this.labelContainerAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownContainerWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownContainerAmount = new System.Windows.Forms.NumericUpDown();
            this.buttonGenerateLayout = new System.Windows.Forms.Button();
            this.numericUpDownShipLength = new System.Windows.Forms.NumericUpDown();
            this.labelShipLength = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownShipWidth = new System.Windows.Forms.NumericUpDown();
            this.listBoxRows = new System.Windows.Forms.ListBox();
            this.listBoxStacks = new System.Windows.Forms.ListBox();
            this.listBoxContainers = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelWeightPercentageLeft = new System.Windows.Forms.Label();
            this.labelWeightPercentageRight = new System.Windows.Forms.Label();
            this.labelTotalWeight = new System.Windows.Forms.Label();
            this.listBoxLeftoverContainers = new System.Windows.Forms.ListBox();
            this.labelLeftoverContainers = new System.Windows.Forms.Label();
            this.labelFinalCheck = new System.Windows.Forms.Label();
            this.labelCalculating = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContainerWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContainerAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShipLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShipWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxContainersInput
            // 
            this.listBoxContainersInput.FormattingEnabled = true;
            this.listBoxContainersInput.Location = new System.Drawing.Point(25, 148);
            this.listBoxContainersInput.Name = "listBoxContainersInput";
            this.listBoxContainersInput.Size = new System.Drawing.Size(288, 277);
            this.listBoxContainersInput.TabIndex = 0;
            // 
            // radioButtonContainer
            // 
            this.radioButtonContainer.AutoSize = true;
            this.radioButtonContainer.Checked = true;
            this.radioButtonContainer.Location = new System.Drawing.Point(115, 17);
            this.radioButtonContainer.Name = "radioButtonContainer";
            this.radioButtonContainer.Size = new System.Drawing.Size(70, 17);
            this.radioButtonContainer.TabIndex = 1;
            this.radioButtonContainer.TabStop = true;
            this.radioButtonContainer.Text = "Container";
            this.radioButtonContainer.UseVisualStyleBackColor = true;
            // 
            // radioButtonCooledContainer
            // 
            this.radioButtonCooledContainer.AutoSize = true;
            this.radioButtonCooledContainer.Location = new System.Drawing.Point(115, 40);
            this.radioButtonCooledContainer.Name = "radioButtonCooledContainer";
            this.radioButtonCooledContainer.Size = new System.Drawing.Size(106, 17);
            this.radioButtonCooledContainer.TabIndex = 2;
            this.radioButtonCooledContainer.Text = "Cooled Container";
            this.radioButtonCooledContainer.UseVisualStyleBackColor = true;
            // 
            // radioButtonValuableContainer
            // 
            this.radioButtonValuableContainer.AutoSize = true;
            this.radioButtonValuableContainer.Location = new System.Drawing.Point(115, 63);
            this.radioButtonValuableContainer.Name = "radioButtonValuableContainer";
            this.radioButtonValuableContainer.Size = new System.Drawing.Size(114, 17);
            this.radioButtonValuableContainer.TabIndex = 3;
            this.radioButtonValuableContainer.Text = "Valuable Container";
            this.radioButtonValuableContainer.UseVisualStyleBackColor = true;
            // 
            // radioButtonCooledValuableContainer
            // 
            this.radioButtonCooledValuableContainer.AutoSize = true;
            this.radioButtonCooledValuableContainer.Location = new System.Drawing.Point(115, 86);
            this.radioButtonCooledValuableContainer.Name = "radioButtonCooledValuableContainer";
            this.radioButtonCooledValuableContainer.Size = new System.Drawing.Size(150, 17);
            this.radioButtonCooledValuableContainer.TabIndex = 4;
            this.radioButtonCooledValuableContainer.Text = "Cooled Valuable Container";
            this.radioButtonCooledValuableContainer.UseVisualStyleBackColor = true;
            // 
            // buttonAddContainer
            // 
            this.buttonAddContainer.Location = new System.Drawing.Point(535, 17);
            this.buttonAddContainer.Name = "buttonAddContainer";
            this.buttonAddContainer.Size = new System.Drawing.Size(79, 86);
            this.buttonAddContainer.TabIndex = 6;
            this.buttonAddContainer.Text = "Add";
            this.buttonAddContainer.UseVisualStyleBackColor = true;
            this.buttonAddContainer.Click += new System.EventHandler(this.buttonAddContainer_Click);
            // 
            // labelContainerWeight
            // 
            this.labelContainerWeight.AutoSize = true;
            this.labelContainerWeight.Location = new System.Drawing.Point(309, 34);
            this.labelContainerWeight.Name = "labelContainerWeight";
            this.labelContainerWeight.Size = new System.Drawing.Size(47, 13);
            this.labelContainerWeight.TabIndex = 7;
            this.labelContainerWeight.Text = "Weight: ";
            // 
            // labelContainerAmount
            // 
            this.labelContainerAmount.AutoSize = true;
            this.labelContainerAmount.Location = new System.Drawing.Point(444, 34);
            this.labelContainerAmount.Name = "labelContainerAmount";
            this.labelContainerAmount.Size = new System.Drawing.Size(46, 13);
            this.labelContainerAmount.TabIndex = 9;
            this.labelContainerAmount.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Containers: ";
            // 
            // numericUpDownContainerWeight
            // 
            this.numericUpDownContainerWeight.Location = new System.Drawing.Point(283, 50);
            this.numericUpDownContainerWeight.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.numericUpDownContainerWeight.Minimum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numericUpDownContainerWeight.Name = "numericUpDownContainerWeight";
            this.numericUpDownContainerWeight.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownContainerWeight.TabIndex = 11;
            this.numericUpDownContainerWeight.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // numericUpDownContainerAmount
            // 
            this.numericUpDownContainerAmount.Location = new System.Drawing.Point(409, 50);
            this.numericUpDownContainerAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownContainerAmount.Name = "numericUpDownContainerAmount";
            this.numericUpDownContainerAmount.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownContainerAmount.TabIndex = 12;
            this.numericUpDownContainerAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonGenerateLayout
            // 
            this.buttonGenerateLayout.Location = new System.Drawing.Point(344, 295);
            this.buttonGenerateLayout.Name = "buttonGenerateLayout";
            this.buttonGenerateLayout.Size = new System.Drawing.Size(155, 130);
            this.buttonGenerateLayout.TabIndex = 13;
            this.buttonGenerateLayout.Text = "Generate Ship Layout";
            this.buttonGenerateLayout.UseVisualStyleBackColor = true;
            this.buttonGenerateLayout.Click += new System.EventHandler(this.buttonGenerateLayout_Click);
            // 
            // numericUpDownShipLength
            // 
            this.numericUpDownShipLength.Location = new System.Drawing.Point(344, 165);
            this.numericUpDownShipLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownShipLength.Name = "numericUpDownShipLength";
            this.numericUpDownShipLength.Size = new System.Drawing.Size(155, 20);
            this.numericUpDownShipLength.TabIndex = 14;
            this.numericUpDownShipLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelShipLength
            // 
            this.labelShipLength.AutoSize = true;
            this.labelShipLength.Location = new System.Drawing.Point(344, 146);
            this.labelShipLength.Name = "labelShipLength";
            this.labelShipLength.Size = new System.Drawing.Size(67, 13);
            this.labelShipLength.TabIndex = 15;
            this.labelShipLength.Text = "Ship Length:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ship Width:";
            // 
            // numericUpDownShipWidth
            // 
            this.numericUpDownShipWidth.Location = new System.Drawing.Point(344, 226);
            this.numericUpDownShipWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownShipWidth.Name = "numericUpDownShipWidth";
            this.numericUpDownShipWidth.Size = new System.Drawing.Size(155, 20);
            this.numericUpDownShipWidth.TabIndex = 16;
            this.numericUpDownShipWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listBoxRows
            // 
            this.listBoxRows.FormattingEnabled = true;
            this.listBoxRows.Location = new System.Drawing.Point(22, 468);
            this.listBoxRows.Name = "listBoxRows";
            this.listBoxRows.Size = new System.Drawing.Size(176, 316);
            this.listBoxRows.TabIndex = 18;
            this.listBoxRows.SelectedIndexChanged += new System.EventHandler(this.listBoxRows_SelectedIndexChanged);
            // 
            // listBoxStacks
            // 
            this.listBoxStacks.FormattingEnabled = true;
            this.listBoxStacks.Location = new System.Drawing.Point(209, 468);
            this.listBoxStacks.Name = "listBoxStacks";
            this.listBoxStacks.Size = new System.Drawing.Size(206, 316);
            this.listBoxStacks.TabIndex = 19;
            this.listBoxStacks.SelectedIndexChanged += new System.EventHandler(this.listBoxStacks_SelectedIndexChanged);
            // 
            // listBoxContainers
            // 
            this.listBoxContainers.FormattingEnabled = true;
            this.listBoxContainers.Location = new System.Drawing.Point(432, 468);
            this.listBoxContainers.Name = "listBoxContainers";
            this.listBoxContainers.Size = new System.Drawing.Size(309, 316);
            this.listBoxContainers.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Rows: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Stacks:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Containers:";
            // 
            // labelWeightPercentageLeft
            // 
            this.labelWeightPercentageLeft.AutoSize = true;
            this.labelWeightPercentageLeft.Location = new System.Drawing.Point(206, 803);
            this.labelWeightPercentageLeft.Name = "labelWeightPercentageLeft";
            this.labelWeightPercentageLeft.Size = new System.Drawing.Size(122, 13);
            this.labelWeightPercentageLeft.TabIndex = 24;
            this.labelWeightPercentageLeft.Text = "Weightpercentage Left: ";
            // 
            // labelWeightPercentageRight
            // 
            this.labelWeightPercentageRight.AutoSize = true;
            this.labelWeightPercentageRight.Location = new System.Drawing.Point(408, 803);
            this.labelWeightPercentageRight.Name = "labelWeightPercentageRight";
            this.labelWeightPercentageRight.Size = new System.Drawing.Size(129, 13);
            this.labelWeightPercentageRight.TabIndex = 25;
            this.labelWeightPercentageRight.Text = "Weightpercentage Right: ";
            // 
            // labelTotalWeight
            // 
            this.labelTotalWeight.AutoSize = true;
            this.labelTotalWeight.Location = new System.Drawing.Point(318, 830);
            this.labelTotalWeight.Name = "labelTotalWeight";
            this.labelTotalWeight.Size = new System.Drawing.Size(102, 13);
            this.labelTotalWeight.TabIndex = 26;
            this.labelTotalWeight.Text = "Total Used Weight: ";
            // 
            // listBoxLeftoverContainers
            // 
            this.listBoxLeftoverContainers.FormattingEnabled = true;
            this.listBoxLeftoverContainers.Location = new System.Drawing.Point(529, 148);
            this.listBoxLeftoverContainers.Name = "listBoxLeftoverContainers";
            this.listBoxLeftoverContainers.Size = new System.Drawing.Size(212, 277);
            this.listBoxLeftoverContainers.TabIndex = 27;
            // 
            // labelLeftoverContainers
            // 
            this.labelLeftoverContainers.AutoSize = true;
            this.labelLeftoverContainers.Location = new System.Drawing.Point(534, 132);
            this.labelLeftoverContainers.Name = "labelLeftoverContainers";
            this.labelLeftoverContainers.Size = new System.Drawing.Size(102, 13);
            this.labelLeftoverContainers.TabIndex = 28;
            this.labelLeftoverContainers.Text = "Leftover Containers:";
            // 
            // labelFinalCheck
            // 
            this.labelFinalCheck.AutoSize = true;
            this.labelFinalCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalCheck.Location = new System.Drawing.Point(252, 857);
            this.labelFinalCheck.Name = "labelFinalCheck";
            this.labelFinalCheck.Size = new System.Drawing.Size(0, 31);
            this.labelFinalCheck.TabIndex = 29;
            // 
            // labelCalculating
            // 
            this.labelCalculating.AutoSize = true;
            this.labelCalculating.Location = new System.Drawing.Point(387, 428);
            this.labelCalculating.Name = "labelCalculating";
            this.labelCalculating.Size = new System.Drawing.Size(0, 13);
            this.labelCalculating.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 897);
            this.Controls.Add(this.labelCalculating);
            this.Controls.Add(this.labelFinalCheck);
            this.Controls.Add(this.labelLeftoverContainers);
            this.Controls.Add(this.listBoxLeftoverContainers);
            this.Controls.Add(this.labelTotalWeight);
            this.Controls.Add(this.labelWeightPercentageRight);
            this.Controls.Add(this.labelWeightPercentageLeft);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxContainers);
            this.Controls.Add(this.listBoxStacks);
            this.Controls.Add(this.listBoxRows);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownShipWidth);
            this.Controls.Add(this.labelShipLength);
            this.Controls.Add(this.numericUpDownShipLength);
            this.Controls.Add(this.buttonGenerateLayout);
            this.Controls.Add(this.numericUpDownContainerAmount);
            this.Controls.Add(this.numericUpDownContainerWeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelContainerAmount);
            this.Controls.Add(this.labelContainerWeight);
            this.Controls.Add(this.buttonAddContainer);
            this.Controls.Add(this.radioButtonCooledValuableContainer);
            this.Controls.Add(this.radioButtonValuableContainer);
            this.Controls.Add(this.radioButtonCooledContainer);
            this.Controls.Add(this.radioButtonContainer);
            this.Controls.Add(this.listBoxContainersInput);
            this.Name = "Form1";
            this.Text = "Containership";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContainerWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContainerAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShipLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShipWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxContainersInput;
        private System.Windows.Forms.RadioButton radioButtonContainer;
        private System.Windows.Forms.RadioButton radioButtonCooledContainer;
        private System.Windows.Forms.RadioButton radioButtonValuableContainer;
        private System.Windows.Forms.RadioButton radioButtonCooledValuableContainer;
        private System.Windows.Forms.Button buttonAddContainer;
        private System.Windows.Forms.Label labelContainerWeight;
        private System.Windows.Forms.Label labelContainerAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownContainerWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownContainerAmount;
        private System.Windows.Forms.Button buttonGenerateLayout;
        private System.Windows.Forms.NumericUpDown numericUpDownShipLength;
        private System.Windows.Forms.Label labelShipLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownShipWidth;
        private System.Windows.Forms.ListBox listBoxRows;
        private System.Windows.Forms.ListBox listBoxStacks;
        private System.Windows.Forms.ListBox listBoxContainers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelWeightPercentageLeft;
        private System.Windows.Forms.Label labelWeightPercentageRight;
        private System.Windows.Forms.Label labelTotalWeight;
        private System.Windows.Forms.ListBox listBoxLeftoverContainers;
        private System.Windows.Forms.Label labelLeftoverContainers;
        private System.Windows.Forms.Label labelFinalCheck;
        private System.Windows.Forms.Label labelCalculating;
    }
}

