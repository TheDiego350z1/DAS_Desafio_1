
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
            this.SuspendLayout();
            // 
            // btnEntrar_Login
            // 
            this.btnEntrar_Login.Location = new System.Drawing.Point(486, 293);
            this.btnEntrar_Login.Name = "btnEntrar_Login";
            this.btnEntrar_Login.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar_Login.TabIndex = 0;
            this.btnEntrar_Login.Text = "Entrar";
            this.btnEntrar_Login.UseVisualStyleBackColor = true;
            this.btnEntrar_Login.Click += new System.EventHandler(this.btnEntrar_Login_Click);
            // 
            // txtName_Login
            // 
            this.txtName_Login.Location = new System.Drawing.Point(356, 94);
            this.txtName_Login.Name = "txtName_Login";
            this.txtName_Login.Size = new System.Drawing.Size(100, 20);
            this.txtName_Login.TabIndex = 1;
            // 
            // txtPass_Login
            // 
            this.txtPass_Login.Location = new System.Drawing.Point(356, 139);
            this.txtPass_Login.Name = "txtPass_Login";
            this.txtPass_Login.Size = new System.Drawing.Size(100, 20);
            this.txtPass_Login.TabIndex = 2;
            // 
            // lbName_Login
            // 
            this.lbName_Login.AutoSize = true;
            this.lbName_Login.Location = new System.Drawing.Point(105, 100);
            this.lbName_Login.Name = "lbName_Login";
            this.lbName_Login.Size = new System.Drawing.Size(96, 13);
            this.lbName_Login.TabIndex = 3;
            this.lbName_Login.Text = "Nombre de usuario";
            // 
            // lbPass_login
            // 
            this.lbPass_login.AutoSize = true;
            this.lbPass_login.Location = new System.Drawing.Point(108, 145);
            this.lbPass_login.Name = "lbPass_login";
            this.lbPass_login.Size = new System.Drawing.Size(61, 13);
            this.lbPass_login.TabIndex = 4;
            this.lbPass_login.Text = "Contraseña";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

