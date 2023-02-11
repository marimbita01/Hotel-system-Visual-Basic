<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Invetory_Management_File
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Invetory_Management_File))
        Dim ClientIDLabel As System.Windows.Forms.Label
        Me.Quantity_sold_destroyed = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ItemName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Quantity_in_Stock = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.Add = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Last = New System.Windows.Forms.Button()
        Me.Nextbtn = New System.Windows.Forms.Button()
        Me.Openreport = New System.Windows.Forms.Button()
        Me.First = New System.Windows.Forms.Button()
        Me.Previous = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.HopeFayHotel_DataSet = New mutsa.HopeFayHotel_DataSet()
        Me.Clients_Booking_FileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Clients_Booking_FileTableAdapter = New mutsa.HopeFayHotel_DataSetTableAdapters.Clients_Booking_FileTableAdapter()
        Me.TableAdapterManager = New mutsa.HopeFayHotel_DataSetTableAdapters.TableAdapterManager()
        Me.Clients_Booking_FileBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Clients_Booking_FileBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ClientIDTextBox = New System.Windows.Forms.TextBox()
        ClientIDLabel = New System.Windows.Forms.Label()
        CType(Me.HopeFayHotel_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clients_Booking_FileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clients_Booking_FileBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Clients_Booking_FileBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Quantity_sold_destroyed
        '
        Me.Quantity_sold_destroyed.Location = New System.Drawing.Point(305, 192)
        Me.Quantity_sold_destroyed.Name = "Quantity_sold_destroyed"
        Me.Quantity_sold_destroyed.Size = New System.Drawing.Size(100, 22)
        Me.Quantity_sold_destroyed.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(52, 199)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(158, 17)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Quantity sold/destroyed"
        '
        'ItemName
        '
        Me.ItemName.Location = New System.Drawing.Point(305, 83)
        Me.ItemName.Name = "ItemName"
        Me.ItemName.Size = New System.Drawing.Size(100, 22)
        Me.ItemName.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Item Name"
        '
        'Quantity_in_Stock
        '
        Me.Quantity_in_Stock.Location = New System.Drawing.Point(305, 164)
        Me.Quantity_in_Stock.Name = "Quantity_in_Stock"
        Me.Quantity_in_Stock.Size = New System.Drawing.Size(100, 22)
        Me.Quantity_in_Stock.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 17)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 17)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Quantity in Stock"
        '
        'DateTextBox
        '
        Me.DateTextBox.Location = New System.Drawing.Point(305, 118)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(100, 22)
        Me.DateTextBox.TabIndex = 21
        '
        'Add
        '
        Me.Add.Location = New System.Drawing.Point(456, 83)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(75, 23)
        Me.Add.TabIndex = 20
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Inventory Management File"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(465, 336)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 35
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Last
        '
        Me.Last.Location = New System.Drawing.Point(346, 306)
        Me.Last.Name = "Last"
        Me.Last.Size = New System.Drawing.Size(75, 23)
        Me.Last.TabIndex = 36
        Me.Last.Text = "Last"
        Me.Last.UseVisualStyleBackColor = True
        '
        'Nextbtn
        '
        Me.Nextbtn.Location = New System.Drawing.Point(346, 242)
        Me.Nextbtn.Name = "Nextbtn"
        Me.Nextbtn.Size = New System.Drawing.Size(75, 23)
        Me.Nextbtn.TabIndex = 37
        Me.Nextbtn.Text = "Next"
        Me.Nextbtn.UseVisualStyleBackColor = True
        '
        'Openreport
        '
        Me.Openreport.Location = New System.Drawing.Point(216, 269)
        Me.Openreport.Name = "Openreport"
        Me.Openreport.Size = New System.Drawing.Size(75, 60)
        Me.Openreport.TabIndex = 38
        Me.Openreport.Text = "Open Report"
        Me.Openreport.UseVisualStyleBackColor = True
        '
        'First
        '
        Me.First.Location = New System.Drawing.Point(55, 306)
        Me.First.Name = "First"
        Me.First.Size = New System.Drawing.Size(75, 23)
        Me.First.TabIndex = 39
        Me.First.Text = "First"
        Me.First.UseVisualStyleBackColor = True
        '
        'Previous
        '
        Me.Previous.Location = New System.Drawing.Point(52, 237)
        Me.Previous.Name = "Previous"
        Me.Previous.Size = New System.Drawing.Size(75, 23)
        Me.Previous.TabIndex = 40
        Me.Previous.Text = "Previous"
        Me.Previous.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(465, 282)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 41
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(465, 253)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 42
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(465, 205)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 43
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(465, 166)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 44
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(465, 127)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 45
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'HopeFayHotel_DataSet
        '
        Me.HopeFayHotel_DataSet.DataSetName = "HopeFayHotel_DataSet"
        Me.HopeFayHotel_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Clients_Booking_FileBindingSource
        '
        Me.Clients_Booking_FileBindingSource.DataMember = "Clients Booking File"
        Me.Clients_Booking_FileBindingSource.DataSource = Me.HopeFayHotel_DataSet
        '
        'Clients_Booking_FileTableAdapter
        '
        Me.Clients_Booking_FileTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Clients_Booking_FileTableAdapter = Me.Clients_Booking_FileTableAdapter
        Me.TableAdapterManager.Clients_Food_Order_FileTableAdapter = Nothing
        Me.TableAdapterManager.Clients_Payment_FileTableAdapter = Nothing
        Me.TableAdapterManager.Inventory_Management_FileTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = mutsa.HopeFayHotel_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Clients_Booking_FileBindingNavigator
        '
        Me.Clients_Booking_FileBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Clients_Booking_FileBindingNavigator.BindingSource = Me.Clients_Booking_FileBindingSource
        Me.Clients_Booking_FileBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Clients_Booking_FileBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Clients_Booking_FileBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Clients_Booking_FileBindingNavigatorSaveItem})
        Me.Clients_Booking_FileBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Clients_Booking_FileBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Clients_Booking_FileBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Clients_Booking_FileBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Clients_Booking_FileBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Clients_Booking_FileBindingNavigator.Name = "Clients_Booking_FileBindingNavigator"
        Me.Clients_Booking_FileBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Clients_Booking_FileBindingNavigator.Size = New System.Drawing.Size(610, 29)
        Me.Clients_Booking_FileBindingNavigator.TabIndex = 46
        Me.Clients_Booking_FileBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 20)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Clients_Booking_FileBindingNavigatorSaveItem
        '
        Me.Clients_Booking_FileBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Clients_Booking_FileBindingNavigatorSaveItem.Image = CType(resources.GetObject("Clients_Booking_FileBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Clients_Booking_FileBindingNavigatorSaveItem.Name = "Clients_Booking_FileBindingNavigatorSaveItem"
        Me.Clients_Booking_FileBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Clients_Booking_FileBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ClientIDLabel
        '
        ClientIDLabel.AutoSize = True
        ClientIDLabel.Location = New System.Drawing.Point(399, 55)
        ClientIDLabel.Name = "ClientIDLabel"
        ClientIDLabel.Size = New System.Drawing.Size(64, 17)
        ClientIDLabel.TabIndex = 46
        ClientIDLabel.Text = "Client ID:"
        '
        'ClientIDTextBox
        '
        Me.ClientIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clients_Booking_FileBindingSource, "ClientID", True))
        Me.ClientIDTextBox.Location = New System.Drawing.Point(469, 52)
        Me.ClientIDTextBox.Name = "ClientIDTextBox"
        Me.ClientIDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ClientIDTextBox.TabIndex = 47
        '
        'Invetory_Management_File
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 432)
        Me.Controls.Add(ClientIDLabel)
        Me.Controls.Add(Me.ClientIDTextBox)
        Me.Controls.Add(Me.Clients_Booking_FileBindingNavigator)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Previous)
        Me.Controls.Add(Me.First)
        Me.Controls.Add(Me.Openreport)
        Me.Controls.Add(Me.Nextbtn)
        Me.Controls.Add(Me.Last)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Quantity_sold_destroyed)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ItemName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Quantity_in_Stock)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTextBox)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Invetory_Management_File"
        Me.Text = "Invetory_Management_File"
        CType(Me.HopeFayHotel_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clients_Booking_FileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clients_Booking_FileBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Clients_Booking_FileBindingNavigator.ResumeLayout(False)
        Me.Clients_Booking_FileBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Quantity_sold_destroyed As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ItemName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Quantity_in_Stock As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Last As System.Windows.Forms.Button
    Friend WithEvents Nextbtn As System.Windows.Forms.Button
    Friend WithEvents Openreport As System.Windows.Forms.Button
    Friend WithEvents First As System.Windows.Forms.Button
    Friend WithEvents Previous As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents HopeFayHotel_DataSet As mutsa.HopeFayHotel_DataSet
    Friend WithEvents Clients_Booking_FileBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Clients_Booking_FileTableAdapter As mutsa.HopeFayHotel_DataSetTableAdapters.Clients_Booking_FileTableAdapter
    Friend WithEvents TableAdapterManager As mutsa.HopeFayHotel_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Clients_Booking_FileBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Clients_Booking_FileBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ClientIDTextBox As System.Windows.Forms.TextBox
End Class
