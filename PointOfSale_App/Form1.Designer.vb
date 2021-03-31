<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoToListOfProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabRecipt = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPayable = New System.Windows.Forms.TextBox()
        Me.txtVAT = New System.Windows.Forms.TextBox()
        Me.txtTaxable = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.dtvReceipt = New System.Windows.Forms.DataGridView()
        Me.productNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiptProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.receiptProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.receiptProductPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabProdList = New System.Windows.Forms.TabPage()
        Me.dtvProductList = New System.Windows.Forms.DataGridView()
        Me.ProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.tabRecipt.SuspendLayout()
        CType(Me.dtvReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabProdList.SuspendLayout()
        CType(Me.dtvProductList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ActionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(690, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ActionToolStripMenuItem
        '
        Me.ActionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewItemsToolStripMenuItem, Me.SearchToolStripMenuItem})
        Me.ActionToolStripMenuItem.Name = "ActionToolStripMenuItem"
        Me.ActionToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.ActionToolStripMenuItem.Text = "Action"
        '
        'NewItemsToolStripMenuItem
        '
        Me.NewItemsToolStripMenuItem.Name = "NewItemsToolStripMenuItem"
        Me.NewItemsToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.NewItemsToolStripMenuItem.Text = "Add"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveToolStripMenuItem, Me.ClearProductsToolStripMenuItem, Me.GoToListOfProductsToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(249, 76)
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(248, 24)
        Me.RemoveToolStripMenuItem.Text = "Remove Selected Product"
        '
        'ClearProductsToolStripMenuItem
        '
        Me.ClearProductsToolStripMenuItem.Name = "ClearProductsToolStripMenuItem"
        Me.ClearProductsToolStripMenuItem.Size = New System.Drawing.Size(248, 24)
        Me.ClearProductsToolStripMenuItem.Text = "Clear Products"
        '
        'GoToListOfProductsToolStripMenuItem
        '
        Me.GoToListOfProductsToolStripMenuItem.Name = "GoToListOfProductsToolStripMenuItem"
        Me.GoToListOfProductsToolStripMenuItem.Size = New System.Drawing.Size(248, 24)
        Me.GoToListOfProductsToolStripMenuItem.Text = "Go to list of Products"
        '
        'tabRecipt
        '
        Me.tabRecipt.Controls.Add(Me.Label5)
        Me.tabRecipt.Controls.Add(Me.Label4)
        Me.tabRecipt.Controls.Add(Me.Label3)
        Me.tabRecipt.Controls.Add(Me.Label2)
        Me.tabRecipt.Controls.Add(Me.Label1)
        Me.tabRecipt.Controls.Add(Me.txtPayable)
        Me.tabRecipt.Controls.Add(Me.txtVAT)
        Me.tabRecipt.Controls.Add(Me.txtTaxable)
        Me.tabRecipt.Controls.Add(Me.txtDiscount)
        Me.tabRecipt.Controls.Add(Me.txtTotalAmount)
        Me.tabRecipt.Controls.Add(Me.dtvReceipt)
        Me.tabRecipt.Location = New System.Drawing.Point(4, 25)
        Me.tabRecipt.Name = "tabRecipt"
        Me.tabRecipt.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRecipt.Size = New System.Drawing.Size(667, 448)
        Me.tabRecipt.TabIndex = 1
        Me.tabRecipt.Text = "Receipt"
        Me.tabRecipt.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(427, 419)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Amount Payable:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(491, 388)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "VAT %:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(432, 360)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Amount Taxable"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(475, 335)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Discount:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(442, 307)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Total  Amount:"
        '
        'txtPayable
        '
        Me.txtPayable.Location = New System.Drawing.Point(548, 416)
        Me.txtPayable.Name = "txtPayable"
        Me.txtPayable.ReadOnly = True
        Me.txtPayable.Size = New System.Drawing.Size(100, 22)
        Me.txtPayable.TabIndex = 5
        '
        'txtVAT
        '
        Me.txtVAT.Location = New System.Drawing.Point(548, 388)
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.ReadOnly = True
        Me.txtVAT.Size = New System.Drawing.Size(100, 22)
        Me.txtVAT.TabIndex = 4
        '
        'txtTaxable
        '
        Me.txtTaxable.Location = New System.Drawing.Point(548, 360)
        Me.txtTaxable.Name = "txtTaxable"
        Me.txtTaxable.ReadOnly = True
        Me.txtTaxable.Size = New System.Drawing.Size(100, 22)
        Me.txtTaxable.TabIndex = 3
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(548, 332)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.ReadOnly = True
        Me.txtDiscount.Size = New System.Drawing.Size(100, 22)
        Me.txtDiscount.TabIndex = 2
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Location = New System.Drawing.Point(548, 304)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalAmount.TabIndex = 1
        '
        'dtvReceipt
        '
        Me.dtvReceipt.BackgroundColor = System.Drawing.Color.White
        Me.dtvReceipt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dtvReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvReceipt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.productNumber, Me.ReceiptProductID, Me.receiptProductName, Me.receiptProductPrice, Me.quantity, Me.productTotal})
        Me.dtvReceipt.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dtvReceipt.Location = New System.Drawing.Point(6, 6)
        Me.dtvReceipt.Name = "dtvReceipt"
        Me.dtvReceipt.RowHeadersWidth = 51
        Me.dtvReceipt.RowTemplate.Height = 24
        Me.dtvReceipt.Size = New System.Drawing.Size(656, 291)
        Me.dtvReceipt.TabIndex = 0
        '
        'productNumber
        '
        Me.productNumber.HeaderText = "Number"
        Me.productNumber.MinimumWidth = 6
        Me.productNumber.Name = "productNumber"
        Me.productNumber.Width = 125
        '
        'ReceiptProductID
        '
        Me.ReceiptProductID.HeaderText = "Product ID"
        Me.ReceiptProductID.MinimumWidth = 6
        Me.ReceiptProductID.Name = "ReceiptProductID"
        Me.ReceiptProductID.Width = 125
        '
        'receiptProductName
        '
        Me.receiptProductName.HeaderText = "Product Name"
        Me.receiptProductName.MinimumWidth = 6
        Me.receiptProductName.Name = "receiptProductName"
        Me.receiptProductName.Width = 125
        '
        'receiptProductPrice
        '
        Me.receiptProductPrice.HeaderText = "Price"
        Me.receiptProductPrice.MinimumWidth = 6
        Me.receiptProductPrice.Name = "receiptProductPrice"
        Me.receiptProductPrice.Width = 125
        '
        'quantity
        '
        Me.quantity.HeaderText = "Quantity"
        Me.quantity.MinimumWidth = 6
        Me.quantity.Name = "quantity"
        Me.quantity.Width = 125
        '
        'productTotal
        '
        Me.productTotal.HeaderText = "Total"
        Me.productTotal.MinimumWidth = 6
        Me.productTotal.Name = "productTotal"
        Me.productTotal.Width = 125
        '
        'tabProdList
        '
        Me.tabProdList.Controls.Add(Me.dtvProductList)
        Me.tabProdList.Location = New System.Drawing.Point(4, 25)
        Me.tabProdList.Name = "tabProdList"
        Me.tabProdList.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProdList.Size = New System.Drawing.Size(667, 448)
        Me.tabProdList.TabIndex = 0
        Me.tabProdList.Text = "Product List"
        Me.tabProdList.UseVisualStyleBackColor = True
        '
        'dtvProductList
        '
        Me.dtvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvProductList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductID, Me.productName, Me.productPrice})
        Me.dtvProductList.Location = New System.Drawing.Point(6, 6)
        Me.dtvProductList.Name = "dtvProductList"
        Me.dtvProductList.RowHeadersWidth = 51
        Me.dtvProductList.RowTemplate.Height = 24
        Me.dtvProductList.Size = New System.Drawing.Size(542, 428)
        Me.dtvProductList.TabIndex = 0
        '
        'ProductID
        '
        Me.ProductID.HeaderText = "Product ID"
        Me.ProductID.MinimumWidth = 6
        Me.ProductID.Name = "ProductID"
        Me.ProductID.Width = 125
        '
        'productName
        '
        Me.productName.HeaderText = "Product Name"
        Me.productName.MinimumWidth = 6
        Me.productName.Name = "productName"
        Me.productName.Width = 125
        '
        'productPrice
        '
        Me.productPrice.HeaderText = "Price"
        Me.productPrice.MinimumWidth = 6
        Me.productPrice.Name = "productPrice"
        Me.productPrice.Width = 125
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabProdList)
        Me.TabControl1.Controls.Add(Me.tabRecipt)
        Me.TabControl1.Location = New System.Drawing.Point(13, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(675, 477)
        Me.TabControl1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 516)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "POS App"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.tabRecipt.ResumeLayout(False)
        Me.tabRecipt.PerformLayout()
        CType(Me.dtvReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabProdList.ResumeLayout(False)
        CType(Me.dtvProductList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewItemsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents tabRecipt As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPayable As TextBox
    Friend WithEvents txtVAT As TextBox
    Friend WithEvents txtTaxable As TextBox
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents dtvReceipt As DataGridView
    Friend WithEvents productNumber As DataGridViewTextBoxColumn
    Friend WithEvents ReceiptProductID As DataGridViewTextBoxColumn
    Friend WithEvents receiptProductName As DataGridViewTextBoxColumn
    Friend WithEvents receiptProductPrice As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents productTotal As DataGridViewTextBoxColumn
    Friend WithEvents tabProdList As TabPage
    Friend WithEvents dtvProductList As DataGridView
    Friend WithEvents ProductID As DataGridViewTextBoxColumn
    Friend WithEvents productName As DataGridViewTextBoxColumn
    Friend WithEvents productPrice As DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GoToListOfProductsToolStripMenuItem As ToolStripMenuItem
End Class
