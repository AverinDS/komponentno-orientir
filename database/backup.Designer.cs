namespace KOP.database
{
    partial class backup
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.choose_db = new System.Windows.Forms.OpenFileDialog();
            this.save_db = new System.Windows.Forms.SaveFileDialog();
            this.interval_of_backup = new System.Windows.Forms.Timer(this.components);
            this.restore_db = new System.Windows.Forms.OpenFileDialog();
            // 
            // choose_db
            // 
            this.choose_db.FileName = "openFileDialog1";
            // 
            // interval_of_backup
            // 
            this.interval_of_backup.Tick += new System.EventHandler(this.interval_of_backup_Tick);
            // 
            // restore_db
            // 
            this.restore_db.FileName = "openFileDialog1";

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog choose_db;
        private System.Windows.Forms.SaveFileDialog save_db;
        private System.Windows.Forms.Timer interval_of_backup;
        private System.Windows.Forms.OpenFileDialog restore_db;
    }
}
