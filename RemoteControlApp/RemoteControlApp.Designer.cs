
namespace RemoteControlApp
{
    partial class RemoteControlApp
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMovementCamera = new System.Windows.Forms.Label();
            this.lblMovementCharacter = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCameraBackward = new System.Windows.Forms.Button();
            this.btnCameraForward = new System.Windows.Forms.Button();
            this.btnCameraRight = new System.Windows.Forms.Button();
            this.btnCameraLeft = new System.Windows.Forms.Button();
            this.btnCameraDown = new System.Windows.Forms.Button();
            this.btnCameraUp = new System.Windows.Forms.Button();
            this.panelCharacter = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.lblMovement = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblRotationCharacter = new System.Windows.Forms.Label();
            this.lblRotationCamera = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRotateBackward = new System.Windows.Forms.Button();
            this.btnRotateForward = new System.Windows.Forms.Button();
            this.btnRotateRight = new System.Windows.Forms.Button();
            this.btnRotateLeft = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCameraRotateRight = new System.Windows.Forms.Button();
            this.btnCameraRotateBackward = new System.Windows.Forms.Button();
            this.btnCameraRotateForward = new System.Windows.Forms.Button();
            this.btnCameraRotateLeft = new System.Windows.Forms.Button();
            this.lblRotation = new System.Windows.Forms.Label();
            this.lblSettings = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblConnection = new System.Windows.Forms.Label();
            this.lblControlCharacter = new System.Windows.Forms.Label();
            this.txtCharacterName = new System.Windows.Forms.TextBox();
            this.txtRotateAmount = new System.Windows.Forms.TextBox();
            this.lblRotateAmount = new System.Windows.Forms.Label();
            this.txtMoveAmount = new System.Windows.Forms.TextBox();
            this.lblMoveAmount = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblHistory = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lstCommands = new System.Windows.Forms.ListBox();
            this.ckbFaceWhenMoving = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCharacter.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblMovementCamera);
            this.panel2.Controls.Add(this.lblMovementCharacter);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panelCharacter);
            this.panel2.Location = new System.Drawing.Point(12, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 192);
            this.panel2.TabIndex = 42;
            // 
            // lblMovementCamera
            // 
            this.lblMovementCamera.AutoSize = true;
            this.lblMovementCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovementCamera.Location = new System.Drawing.Point(216, 15);
            this.lblMovementCamera.Name = "lblMovementCamera";
            this.lblMovementCamera.Size = new System.Drawing.Size(53, 13);
            this.lblMovementCamera.TabIndex = 29;
            this.lblMovementCamera.Text = "Camera:";
            // 
            // lblMovementCharacter
            // 
            this.lblMovementCharacter.AutoSize = true;
            this.lblMovementCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovementCharacter.Location = new System.Drawing.Point(24, 15);
            this.lblMovementCharacter.Name = "lblMovementCharacter";
            this.lblMovementCharacter.Size = new System.Drawing.Size(66, 13);
            this.lblMovementCharacter.TabIndex = 28;
            this.lblMovementCharacter.Text = "Character:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCameraBackward);
            this.panel1.Controls.Add(this.btnCameraForward);
            this.panel1.Controls.Add(this.btnCameraRight);
            this.panel1.Controls.Add(this.btnCameraLeft);
            this.panel1.Controls.Add(this.btnCameraDown);
            this.panel1.Controls.Add(this.btnCameraUp);
            this.panel1.Location = new System.Drawing.Point(212, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 150);
            this.panel1.TabIndex = 26;
            // 
            // btnCameraBackward
            // 
            this.btnCameraBackward.Location = new System.Drawing.Point(54, 93);
            this.btnCameraBackward.Name = "btnCameraBackward";
            this.btnCameraBackward.Size = new System.Drawing.Size(34, 31);
            this.btnCameraBackward.TabIndex = 16;
            this.btnCameraBackward.UseVisualStyleBackColor = true;
            this.btnCameraBackward.Click += new System.EventHandler(this.btnCameraBackward_Click);
            // 
            // btnCameraForward
            // 
            this.btnCameraForward.Location = new System.Drawing.Point(54, 19);
            this.btnCameraForward.Name = "btnCameraForward";
            this.btnCameraForward.Size = new System.Drawing.Size(34, 31);
            this.btnCameraForward.TabIndex = 15;
            this.btnCameraForward.UseVisualStyleBackColor = true;
            this.btnCameraForward.Click += new System.EventHandler(this.btnCameraForward_Click);
            // 
            // btnCameraRight
            // 
            this.btnCameraRight.Location = new System.Drawing.Point(94, 56);
            this.btnCameraRight.Name = "btnCameraRight";
            this.btnCameraRight.Size = new System.Drawing.Size(34, 31);
            this.btnCameraRight.TabIndex = 14;
            this.btnCameraRight.UseVisualStyleBackColor = true;
            this.btnCameraRight.Click += new System.EventHandler(this.btnCameraRight_Click);
            // 
            // btnCameraLeft
            // 
            this.btnCameraLeft.Location = new System.Drawing.Point(14, 56);
            this.btnCameraLeft.Name = "btnCameraLeft";
            this.btnCameraLeft.Size = new System.Drawing.Size(34, 31);
            this.btnCameraLeft.TabIndex = 13;
            this.btnCameraLeft.UseVisualStyleBackColor = true;
            this.btnCameraLeft.Click += new System.EventHandler(this.btnCameraLeft_Click);
            // 
            // btnCameraDown
            // 
            this.btnCameraDown.Location = new System.Drawing.Point(141, 93);
            this.btnCameraDown.Name = "btnCameraDown";
            this.btnCameraDown.Size = new System.Drawing.Size(34, 31);
            this.btnCameraDown.TabIndex = 12;
            this.btnCameraDown.UseVisualStyleBackColor = true;
            this.btnCameraDown.Click += new System.EventHandler(this.btnCameraDown_Click);
            // 
            // btnCameraUp
            // 
            this.btnCameraUp.Location = new System.Drawing.Point(141, 19);
            this.btnCameraUp.Name = "btnCameraUp";
            this.btnCameraUp.Size = new System.Drawing.Size(34, 31);
            this.btnCameraUp.TabIndex = 11;
            this.btnCameraUp.UseVisualStyleBackColor = true;
            this.btnCameraUp.Click += new System.EventHandler(this.btnCameraUp_Click);
            // 
            // panelCharacter
            // 
            this.panelCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelCharacter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCharacter.Controls.Add(this.btnDelete);
            this.panelCharacter.Controls.Add(this.btnBackward);
            this.panelCharacter.Controls.Add(this.btnForward);
            this.panelCharacter.Controls.Add(this.btnRight);
            this.panelCharacter.Controls.Add(this.btnLeft);
            this.panelCharacter.Controls.Add(this.btnDown);
            this.panelCharacter.Controls.Add(this.btnUp);
            this.panelCharacter.Location = new System.Drawing.Point(18, 22);
            this.panelCharacter.Name = "panelCharacter";
            this.panelCharacter.Size = new System.Drawing.Size(178, 150);
            this.panelCharacter.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(56, 63);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(18, 18);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.Location = new System.Drawing.Point(48, 94);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(34, 31);
            this.btnBackward.TabIndex = 16;
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(48, 20);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(34, 31);
            this.btnForward.TabIndex = 15;
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(88, 57);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(34, 31);
            this.btnRight.TabIndex = 14;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(8, 57);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(34, 31);
            this.btnLeft.TabIndex = 13;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(131, 94);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(34, 31);
            this.btnDown.TabIndex = 12;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(131, 20);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(34, 31);
            this.btnUp.TabIndex = 11;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // lblMovement
            // 
            this.lblMovement.AutoSize = true;
            this.lblMovement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovement.Location = new System.Drawing.Point(20, 16);
            this.lblMovement.Name = "lblMovement";
            this.lblMovement.Size = new System.Drawing.Size(96, 20);
            this.lblMovement.TabIndex = 44;
            this.lblMovement.Text = "Movement:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblRotationCharacter);
            this.panel3.Controls.Add(this.lblRotationCamera);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(449, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(418, 192);
            this.panel3.TabIndex = 43;
            // 
            // lblRotationCharacter
            // 
            this.lblRotationCharacter.AutoSize = true;
            this.lblRotationCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotationCharacter.Location = new System.Drawing.Point(22, 15);
            this.lblRotationCharacter.Name = "lblRotationCharacter";
            this.lblRotationCharacter.Size = new System.Drawing.Size(66, 13);
            this.lblRotationCharacter.TabIndex = 29;
            this.lblRotationCharacter.Text = "Character:";
            // 
            // lblRotationCamera
            // 
            this.lblRotationCamera.AutoSize = true;
            this.lblRotationCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotationCamera.Location = new System.Drawing.Point(229, 15);
            this.lblRotationCamera.Name = "lblRotationCamera";
            this.lblRotationCamera.Size = new System.Drawing.Size(53, 13);
            this.lblRotationCamera.TabIndex = 28;
            this.lblRotationCamera.Text = "Camera:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnRotateBackward);
            this.panel4.Controls.Add(this.btnRotateForward);
            this.panel4.Controls.Add(this.btnRotateRight);
            this.panel4.Controls.Add(this.btnRotateLeft);
            this.panel4.Location = new System.Drawing.Point(18, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(189, 150);
            this.panel4.TabIndex = 26;
            // 
            // btnRotateBackward
            // 
            this.btnRotateBackward.Location = new System.Drawing.Point(76, 96);
            this.btnRotateBackward.Name = "btnRotateBackward";
            this.btnRotateBackward.Size = new System.Drawing.Size(34, 31);
            this.btnRotateBackward.TabIndex = 53;
            this.btnRotateBackward.UseVisualStyleBackColor = true;
            this.btnRotateBackward.Click += new System.EventHandler(this.btnRotateBackward_Click);
            // 
            // btnRotateForward
            // 
            this.btnRotateForward.Location = new System.Drawing.Point(76, 22);
            this.btnRotateForward.Name = "btnRotateForward";
            this.btnRotateForward.Size = new System.Drawing.Size(34, 31);
            this.btnRotateForward.TabIndex = 52;
            this.btnRotateForward.UseVisualStyleBackColor = true;
            this.btnRotateForward.Click += new System.EventHandler(this.btnRotateForward_Click);
            // 
            // btnRotateRight
            // 
            this.btnRotateRight.Location = new System.Drawing.Point(116, 59);
            this.btnRotateRight.Name = "btnRotateRight";
            this.btnRotateRight.Size = new System.Drawing.Size(34, 31);
            this.btnRotateRight.TabIndex = 51;
            this.btnRotateRight.UseVisualStyleBackColor = true;
            this.btnRotateRight.Click += new System.EventHandler(this.btnRotateRight_Click);
            // 
            // btnRotateLeft
            // 
            this.btnRotateLeft.Location = new System.Drawing.Point(36, 59);
            this.btnRotateLeft.Name = "btnRotateLeft";
            this.btnRotateLeft.Size = new System.Drawing.Size(34, 31);
            this.btnRotateLeft.TabIndex = 50;
            this.btnRotateLeft.UseVisualStyleBackColor = true;
            this.btnRotateLeft.Click += new System.EventHandler(this.btnRotateLeft_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnCameraRotateRight);
            this.panel5.Controls.Add(this.btnCameraRotateBackward);
            this.panel5.Controls.Add(this.btnCameraRotateForward);
            this.panel5.Controls.Add(this.btnCameraRotateLeft);
            this.panel5.Location = new System.Drawing.Point(223, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(178, 150);
            this.panel5.TabIndex = 11;
            // 
            // btnCameraRotateRight
            // 
            this.btnCameraRotateRight.Location = new System.Drawing.Point(111, 59);
            this.btnCameraRotateRight.Name = "btnCameraRotateRight";
            this.btnCameraRotateRight.Size = new System.Drawing.Size(34, 31);
            this.btnCameraRotateRight.TabIndex = 40;
            this.btnCameraRotateRight.UseVisualStyleBackColor = true;
            this.btnCameraRotateRight.Click += new System.EventHandler(this.btnCameraRotateRight_Click);
            // 
            // btnCameraRotateBackward
            // 
            this.btnCameraRotateBackward.Location = new System.Drawing.Point(71, 96);
            this.btnCameraRotateBackward.Name = "btnCameraRotateBackward";
            this.btnCameraRotateBackward.Size = new System.Drawing.Size(34, 31);
            this.btnCameraRotateBackward.TabIndex = 42;
            this.btnCameraRotateBackward.UseVisualStyleBackColor = true;
            this.btnCameraRotateBackward.Click += new System.EventHandler(this.btnCameraRotateBackward_Click);
            // 
            // btnCameraRotateForward
            // 
            this.btnCameraRotateForward.Location = new System.Drawing.Point(71, 22);
            this.btnCameraRotateForward.Name = "btnCameraRotateForward";
            this.btnCameraRotateForward.Size = new System.Drawing.Size(34, 31);
            this.btnCameraRotateForward.TabIndex = 41;
            this.btnCameraRotateForward.UseVisualStyleBackColor = true;
            this.btnCameraRotateForward.Click += new System.EventHandler(this.btnCameraRotateForward_Click);
            // 
            // btnCameraRotateLeft
            // 
            this.btnCameraRotateLeft.Location = new System.Drawing.Point(31, 59);
            this.btnCameraRotateLeft.Name = "btnCameraRotateLeft";
            this.btnCameraRotateLeft.Size = new System.Drawing.Size(34, 31);
            this.btnCameraRotateLeft.TabIndex = 39;
            this.btnCameraRotateLeft.UseVisualStyleBackColor = true;
            this.btnCameraRotateLeft.Click += new System.EventHandler(this.btnCameraRotateLeft_Click);
            // 
            // lblRotation
            // 
            this.lblRotation.AutoSize = true;
            this.lblRotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotation.Location = new System.Drawing.Point(457, 17);
            this.lblRotation.Name = "lblRotation";
            this.lblRotation.Size = new System.Drawing.Size(83, 20);
            this.lblRotation.TabIndex = 45;
            this.lblRotation.Text = "Rotation:";
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.Location = new System.Drawing.Point(457, 235);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(81, 20);
            this.lblSettings.TabIndex = 47;
            this.lblSettings.Text = "Settings:";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.ckbFaceWhenMoving);
            this.panel6.Controls.Add(this.lblConnection);
            this.panel6.Controls.Add(this.lblControlCharacter);
            this.panel6.Controls.Add(this.txtCharacterName);
            this.panel6.Controls.Add(this.txtRotateAmount);
            this.panel6.Controls.Add(this.lblRotateAmount);
            this.panel6.Controls.Add(this.txtMoveAmount);
            this.panel6.Controls.Add(this.lblMoveAmount);
            this.panel6.Controls.Add(this.txtPort);
            this.panel6.Controls.Add(this.txtIP);
            this.panel6.Location = new System.Drawing.Point(449, 245);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(418, 146);
            this.panel6.TabIndex = 46;
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Location = new System.Drawing.Point(15, 56);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(130, 13);
            this.lblConnection.TabIndex = 51;
            this.lblConnection.Text = "Plugin Server Connection:";
            // 
            // lblControlCharacter
            // 
            this.lblControlCharacter.AutoSize = true;
            this.lblControlCharacter.Location = new System.Drawing.Point(15, 23);
            this.lblControlCharacter.Name = "lblControlCharacter";
            this.lblControlCharacter.Size = new System.Drawing.Size(92, 13);
            this.lblControlCharacter.TabIndex = 50;
            this.lblControlCharacter.Text = "Control Character:";
            // 
            // txtCharacterName
            // 
            this.txtCharacterName.Location = new System.Drawing.Point(110, 20);
            this.txtCharacterName.Name = "txtCharacterName";
            this.txtCharacterName.Size = new System.Drawing.Size(291, 20);
            this.txtCharacterName.TabIndex = 49;
            this.txtCharacterName.Text = "Jon";
            // 
            // txtRotateAmount
            // 
            this.txtRotateAmount.Location = new System.Drawing.Point(120, 112);
            this.txtRotateAmount.Name = "txtRotateAmount";
            this.txtRotateAmount.Size = new System.Drawing.Size(45, 20);
            this.txtRotateAmount.TabIndex = 47;
            this.txtRotateAmount.Text = "5.0";
            this.txtRotateAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRotateAmount
            // 
            this.lblRotateAmount.AutoSize = true;
            this.lblRotateAmount.Location = new System.Drawing.Point(16, 113);
            this.lblRotateAmount.Name = "lblRotateAmount";
            this.lblRotateAmount.Size = new System.Drawing.Size(81, 13);
            this.lblRotateAmount.TabIndex = 46;
            this.lblRotateAmount.Text = "Rotate Amount:";
            // 
            // txtMoveAmount
            // 
            this.txtMoveAmount.Location = new System.Drawing.Point(120, 86);
            this.txtMoveAmount.Name = "txtMoveAmount";
            this.txtMoveAmount.Size = new System.Drawing.Size(45, 20);
            this.txtMoveAmount.TabIndex = 45;
            this.txtMoveAmount.Text = "1.0";
            this.txtMoveAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMoveAmount
            // 
            this.lblMoveAmount.AutoSize = true;
            this.lblMoveAmount.Location = new System.Drawing.Point(15, 89);
            this.lblMoveAmount.Name = "lblMoveAmount";
            this.lblMoveAmount.Size = new System.Drawing.Size(99, 13);
            this.lblMoveAmount.TabIndex = 44;
            this.lblMoveAmount.Text = "Movement Amount:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(346, 53);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(55, 20);
            this.txtPort.TabIndex = 43;
            this.txtPort.Text = "11000";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(151, 53);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(189, 20);
            this.txtIP.TabIndex = 42;
            this.txtIP.Text = "127.0.0.1";
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.Location = new System.Drawing.Point(20, 235);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(70, 20);
            this.lblHistory.TabIndex = 49;
            this.lblHistory.Text = "History:";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lstCommands);
            this.panel7.Location = new System.Drawing.Point(12, 245);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(418, 146);
            this.panel7.TabIndex = 48;
            // 
            // lstCommands
            // 
            this.lstCommands.FormattingEnabled = true;
            this.lstCommands.Location = new System.Drawing.Point(14, 18);
            this.lstCommands.Name = "lstCommands";
            this.lstCommands.Size = new System.Drawing.Size(386, 108);
            this.lstCommands.TabIndex = 0;
            // 
            // ckbFaceWhenMoving
            // 
            this.ckbFaceWhenMoving.AutoSize = true;
            this.ckbFaceWhenMoving.Checked = true;
            this.ckbFaceWhenMoving.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbFaceWhenMoving.Location = new System.Drawing.Point(196, 90);
            this.ckbFaceWhenMoving.Name = "ckbFaceWhenMoving";
            this.ckbFaceWhenMoving.Size = new System.Drawing.Size(133, 17);
            this.ckbFaceWhenMoving.TabIndex = 52;
            this.ckbFaceWhenMoving.Text = "Face Moving Direction";
            this.ckbFaceWhenMoving.UseVisualStyleBackColor = true;
            // 
            // RemoteControlApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 403);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.lblRotation);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblMovement);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemoteControlApp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Talespire Remote Control";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelCharacter.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMovementCamera;
        private System.Windows.Forms.Label lblMovementCharacter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCameraBackward;
        private System.Windows.Forms.Button btnCameraForward;
        private System.Windows.Forms.Button btnCameraRight;
        private System.Windows.Forms.Button btnCameraLeft;
        private System.Windows.Forms.Button btnCameraDown;
        private System.Windows.Forms.Button btnCameraUp;
        private System.Windows.Forms.Panel panelCharacter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Label lblMovement;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblRotationCharacter;
        private System.Windows.Forms.Label lblRotationCamera;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRotateBackward;
        private System.Windows.Forms.Button btnRotateForward;
        private System.Windows.Forms.Button btnRotateRight;
        private System.Windows.Forms.Button btnRotateLeft;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCameraRotateRight;
        private System.Windows.Forms.Button btnCameraRotateBackward;
        private System.Windows.Forms.Button btnCameraRotateForward;
        private System.Windows.Forms.Button btnCameraRotateLeft;
        private System.Windows.Forms.Label lblRotation;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Label lblControlCharacter;
        private System.Windows.Forms.TextBox txtCharacterName;
        private System.Windows.Forms.TextBox txtRotateAmount;
        private System.Windows.Forms.Label lblRotateAmount;
        private System.Windows.Forms.TextBox txtMoveAmount;
        private System.Windows.Forms.Label lblMoveAmount;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ListBox lstCommands;
        private System.Windows.Forms.CheckBox ckbFaceWhenMoving;
    }
}

