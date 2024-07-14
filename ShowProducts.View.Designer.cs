namespace Northwind.ShowProduct.Views
{
    partial class ShowProductsView
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
            this.grid1 = new Northwind.Shared.Theme.Controls.Grid();
            this.gcProductID = new Northwind.Shared.Theme.Controls.GridColumn();
            this.txtProductID1 = new Northwind.Shared.Theme.Controls.TextBox();
            this.gcProductName = new Northwind.Shared.Theme.Controls.GridColumn();
            this.txtProductName1 = new Northwind.Shared.Theme.Controls.TextBox();
            this.gcCategoryID = new Northwind.Shared.Theme.Controls.GridColumn();
            this.txtCategoryID = new Northwind.Shared.Theme.Controls.TextBox();
            this.gcUnitsInStock = new Northwind.Shared.Theme.Controls.GridColumn();
            this.txtUnitsInStock1 = new Northwind.Shared.Theme.Controls.TextBox();
            this.gcQuantityPerUnit = new Northwind.Shared.Theme.Controls.GridColumn();
            this.txtQuantityPerUnit = new Northwind.Shared.Theme.Controls.TextBox();
            this.grid1.SuspendLayout();
            this.gcProductID.SuspendLayout();
            this.gcProductName.SuspendLayout();
            this.gcCategoryID.SuspendLayout();
            this.gcUnitsInStock.SuspendLayout();
            this.gcQuantityPerUnit.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid1
            // 
            this.grid1.Controls.Add(this.gcProductID);
            this.grid1.Controls.Add(this.gcProductName);
            this.grid1.Controls.Add(this.gcCategoryID);
            this.grid1.Controls.Add(this.gcUnitsInStock);
            this.grid1.Controls.Add(this.gcQuantityPerUnit);
            this.grid1.Location = new System.Drawing.Point(19, 21);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(540, 294);
            this.grid1.Text = "grid1";
            // 
            // gcProductID
            // 
            this.gcProductID.Controls.Add(this.txtProductID1);
            this.gcProductID.Name = "gcProductID";
            this.gcProductID.Text = "ProductID";
            this.gcProductID.Width = 109;
            // 
            // txtProductID1
            // 
            this.txtProductID1.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 100);
            this.txtProductID1.Location = new System.Drawing.Point(2, 1);
            this.txtProductID1.Name = "txtProductID1";
            this.txtProductID1.Size = new System.Drawing.Size(103, 18);
            this.txtProductID1.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtProductID1.Data = this._controller.Products.ProductID;
            // 
            // gcProductName
            // 
            this.gcProductName.Controls.Add(this.txtProductName1);
            this.gcProductName.Name = "gcProductName";
            this.gcProductName.Text = "ProductName";
            this.gcProductName.Width = 235;
            // 
            // txtProductName1
            // 
            this.txtProductName1.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 100);
            this.txtProductName1.Location = new System.Drawing.Point(2, 1);
            this.txtProductName1.Name = "txtProductName1";
            this.txtProductName1.Size = new System.Drawing.Size(229, 18);
            this.txtProductName1.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtProductName1.Data = this._controller.Products.ProductName;
            // 
            // gcCategoryID
            // 
            this.gcCategoryID.Controls.Add(this.txtCategoryID);
            this.gcCategoryID.Name = "gcCategoryID";
            this.gcCategoryID.Text = "CategoryID";
            this.gcCategoryID.Width = 109;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 100);
            this.txtCategoryID.Location = new System.Drawing.Point(2, 1);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(103, 18);
            this.txtCategoryID.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtCategoryID.Data = this._controller.Products.CategoryID;
            // 
            // gcUnitsInStock
            // 
            this.gcUnitsInStock.Controls.Add(this.txtUnitsInStock1);
            this.gcUnitsInStock.Name = "gcUnitsInStock";
            this.gcUnitsInStock.Text = "UnitsInStock";
            this.gcUnitsInStock.Width = 69;
            // 
            // txtUnitsInStock1
            // 
            this.txtUnitsInStock1.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 100);
            this.txtUnitsInStock1.Location = new System.Drawing.Point(2, 1);
            this.txtUnitsInStock1.Name = "txtUnitsInStock1";
            this.txtUnitsInStock1.Size = new System.Drawing.Size(58, 18);
            this.txtUnitsInStock1.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtUnitsInStock1.Data = this._controller.Products.UnitsInStock;
            // 
            // gcQuantityPerUnit
            // 
            this.gcQuantityPerUnit.Controls.Add(this.txtQuantityPerUnit);
            this.gcQuantityPerUnit.Name = "gcQuantityPerUnit";
            this.gcQuantityPerUnit.Text = "QuantityPerUnit";
            this.gcQuantityPerUnit.Width = 190;
            // 
            // txtQuantityPerUnit
            // 
            this.txtQuantityPerUnit.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 100);
            this.txtQuantityPerUnit.Location = new System.Drawing.Point(2, 1);
            this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            this.txtQuantityPerUnit.Size = new System.Drawing.Size(184, 18);
            this.txtQuantityPerUnit.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtQuantityPerUnit.Data = this._controller.Products.QuantityPerUnit;
            // 
            // ShowProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 327);
            this.Controls.Add(this.grid1);
            this.HorizontalExpressionFactor = 1D;
            this.HorizontalScale = 1D;
            this.Name = "ShowProductsView";
            this.Text = "ShowProducts";
            this.VerticalExpressionFactor = 1D;
            this.VerticalScale = 1D;
            this.grid1.ResumeLayout(false);
            this.gcProductID.ResumeLayout(false);
            this.gcProductName.ResumeLayout(false);
            this.gcCategoryID.ResumeLayout(false);
            this.gcUnitsInStock.ResumeLayout(false);
            this.gcQuantityPerUnit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Shared.Theme.Controls.Grid grid1;
        private Shared.Theme.Controls.GridColumn gcProductID;
        private Shared.Theme.Controls.TextBox txtProductID1;
        private Shared.Theme.Controls.GridColumn gcProductName;
        private Shared.Theme.Controls.TextBox txtProductName1;
        private Shared.Theme.Controls.GridColumn gcCategoryID;
        private Shared.Theme.Controls.TextBox txtCategoryID;
        private Shared.Theme.Controls.GridColumn gcUnitsInStock;
        private Shared.Theme.Controls.TextBox txtUnitsInStock1;
        private Shared.Theme.Controls.GridColumn gcQuantityPerUnit;
        private Shared.Theme.Controls.TextBox txtQuantityPerUnit;
    }
}