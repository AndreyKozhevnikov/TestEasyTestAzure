namespace dxT844058v1.Win {
    partial class dxT844058v1WindowsFormsApplication {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
            this.module2 = new DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule();
            this.module3 = new dxT844058v1.Module.dxT844058v1Module();
            this.module4 = new dxT844058v1.Module.Win.dxT844058v1WindowsFormsModule();
			//secur#2
			//report#0
			//office#4
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			//secur#3
			//report#1#
			//office#14#
            // 
            // dxT844058v1WindowsFormsApplication
            // 
            this.ApplicationName = "dxT844058v1";
            this.CheckCompatibilityType = DevExpress.ExpressApp.CheckCompatibilityType.DatabaseSchema;
            this.Modules.Add(this.module1);
            this.Modules.Add(this.module2);
			//report#2
			//office#6
            this.Modules.Add(this.module3);
            this.Modules.Add(this.module4);
			//secur#4
            this.UseOldTemplates = false;
            this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.dxT844058v1WindowsFormsApplication_DatabaseVersionMismatch);
            this.CustomizeLanguagesList += new System.EventHandler<DevExpress.ExpressApp.CustomizeLanguagesListEventArgs>(this.dxT844058v1WindowsFormsApplication_CustomizeLanguagesList);

            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.ExpressApp.SystemModule.SystemModule module1;
        private DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule module2;
        private dxT844058v1.Module.dxT844058v1Module module3;
        private dxT844058v1.Module.Win.dxT844058v1WindowsFormsModule module4;
		//secur#1#
		//report#3
		//office#7
    }
}
