
namespace DAS_Desafio_1
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEntrar_Login = new System.Windows.Forms.Button();
            this.txtName_Login = new System.Windows.Forms.TextBox();
            this.txtPass_Login = new System.Windows.Forms.TextBox();
            this.lbName_Login = new System.Windows.Forms.Label();
            this.lbPass_login = new System.Windows.Forms.Label();
            this.lbId_Login = new System.Windows.Forms.Label();
            this.txtId_login = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEntrar_Login
            // 
            this.btnEntrar_Login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEntrar_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar_Login.Location = new System.Drawing.Point(369, 280);
            this.btnEntrar_Login.Name = "btnEntrar_Login";
            this.btnEntrar_Login.Size = new System.Drawing.Size(73, 33);
            this.btnEntrar_Login.TabIndex = 0;
            this.btnEntrar_Login.Text = "Entrar";
            this.btnEntrar_Login.UseVisualStyleBackColor = false;
            this.btnEntrar_Login.Click += new System.EventHandler(this.btnEntrar_Login_Click);
            // 
            // txtName_Login
            // 
            this.txtName_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName_Login.Location = new System.Drawing.Point(356, 94);
            this.txtName_Login.Name = "txtName_Login";
            this.txtName_Login.Size = new System.Drawing.Size(100, 26);
            this.txtName_Login.TabIndex = 1;
            // 
            // txtPass_Login
            // 
            this.txtPass_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass_Login.Location = new System.Drawing.Point(356, 139);
            this.txtPass_Login.Name = "txtPass_Login";
            this.txtPass_Login.PasswordChar = '*';
            this.txtPass_Login.Size = new System.Drawing.Size(100, 26);
            this.txtPass_Login.TabIndex = 2;
            // 
            // lbName_Login
            // 
            this.lbName_Login.AutoSize = true;
            this.lbName_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName_Login.Location = new System.Drawing.Point(105, 100);
            this.lbName_Login.Name = "lbName_Login";
            this.lbName_Login.Size = new System.Drawing.Size(143, 20);
            this.lbName_Login.TabIndex = 3;
            this.lbName_Login.Text = "Nombre de usuario";
            // 
            // lbPass_login
            // 
            this.lbPass_login.AutoSize = true;
            this.lbPass_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass_login.Location = new System.Drawing.Point(105, 142);
            this.lbPass_login.Name = "lbPass_login";
            this.lbPass_login.Size = new System.Drawing.Size(92, 20);
            this.lbPass_login.TabIndex = 4;
            this.lbPass_login.Text = "Contraseña";
            // 
            // lbId_Login
            // 
            this.lbId_Login.AutoSize = true;
            this.lbId_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId_Login.Location = new System.Drawing.Point(105, 212);
            this.lbId_Login.Name = "lbId_Login";
            this.lbId_Login.Size = new System.Drawing.Size(23, 20);
            this.lbId_Login.TabIndex = 5;
            this.lbId_Login.Text = "Id";
            // 
            // txtId_login
            // 
            this.txtId_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId_login.Location = new System.Drawing.Point(356, 206);
            this.txtId_login.Name = "txtId_login";
            this.txtId_login.Size = new System.Drawing.Size(100, 26);
            this.txtId_login.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(109, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtId_login);
            this.Controls.Add(this.lbId_Login);
            this.Controls.Add(this.lbPass_login);
            this.Controls.Add(this.lbName_Login);
            this.Controls.Add(this.txtPass_Login);
            this.Controls.Add(this.txtName_Login);
            this.Controls.Add(this.btnEntrar_Login);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar_Login;
        private System.Windows.Forms.TextBox txtName_Login;
        private System.Windows.Forms.TextBox txtPass_Login;
        private System.Windows.Forms.Label lbName_Login;
        private System.Windows.Forms.Label lbPass_login;
        private System.Windows.Forms.Label lbId_Login;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtId_login;
    }
}

