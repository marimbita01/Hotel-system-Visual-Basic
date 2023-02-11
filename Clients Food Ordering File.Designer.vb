<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clients_Food_Ordering_File
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
        Me.Description = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ClientID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Quantity = New System.Windows.Forms.TextBox()
        Me.OrderNumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Previous = New System.Windows.Forms.Button()
        Me.First = New System.Windows.Forms.Button()
        Me.Openreport = New System.Windows.Forms.Button()
        Me.Nextbtn = New System.Windows.Forms.Button()
        Me.Last = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Add = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Description
        '
        Me.Description.Location = New System.Drawing.Point(315, 211)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(100, 22)
        Me.Description.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(62, 218)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 17)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Description"
        '
        'ClientID
        '
        Me.ClientID.Location = New System.Drawing.Point(315, 102)
        Me.ClientID.Name = "ClientID"
        Me.ClientID.Size = New System.Drawing.Size(100, 22)
        Me.ClientID.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "ClientID"
        '
        'Quantity
        '
        Me.Quantity.Location = New System.Drawing.Point(315, 240)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(100, 22)
        Me.Quantity.TabIndex = 28
        '
        'OrderNumber
        '
        Me.OrderNumber.Location = New System.Drawing.Point(315, 183)
        Me.OrderNumber.Name = "OrderNumber"
        Me.OrderNumber.Size = New System.Drawing.Size(100, 22)
        Me.OrderNumber.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(62, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 17)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(62, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 17)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Order Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Quantity"
        '
        'DateTextBox
        '
        Me.DateTextBox.Location = New System.Drawing.Point(315, 137)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(100, 22)
        Me.DateTextBox.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Client Food Ordering File"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(472, 196)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 57
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(472, 235)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 56
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(472, 274)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 55
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(472, 322)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 54
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(472, 351)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 53
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Previous
        '
        Me.Previous.Location = New System.Drawing.Point(59, 306)
        Me.Previous.Name = "Previous"
        Me.Previous.Size = New System.Drawing.Size(75, 23)
        Me.Previous.TabIndex = 52
        Me.Previous.Text = "Previous"
        Me.Previous.UseVisualStyleBackColor = True
        '
        'First
        '
        Me.First.Location = New System.Drawing.Point(62, 375)
        Me.First.Name = "First"
        Me.First.Size = New System.Drawing.Size(75, 23)
        Me.First.TabIndex = 51
        Me.First.Text = "First"
        Me.First.UseVisualStyleBackColor = True
        '
        'Openreport
        '
        Me.Openreport.Location = New System.Drawing.Point(223, 338)
        Me.Openreport.Name = "Openreport"
        Me.Openreport.Size = New System.Drawing.Size(75, 60)
        Me.Openreport.TabIndex = 50
        Me.Openreport.Text = "Open Report"
        Me.Openreport.UseVisualStyleBackColor = True
        '
        'Nextbtn
        '
        Me.Nextbtn.Location = New System.Drawing.Point(353, 311)
        Me.Nextbtn.Name = "Nextbtn"
        Me.Nextbtn.Size = New System.Drawing.Size(75, 23)
        Me.Nextbtn.TabIndex = 49
        Me.Nextbtn.Text = "Next"
        Me.Nextbtn.UseVisualStyleBackColor = True
        '
        'Last
        '
        Me.Last.Location = New System.Drawing.Point(353, 375)
        Me.Last.Name = "Last"
        Me.Last.Size = New System.Drawing.Size(75, 23)
        Me.Last.TabIndex = 48
        Me.Last.Text = "Last"
        Me.Last.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(472, 405)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 47
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Add
        '
        Me.Add.Location = New System.Drawing.Point(463, 152)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(75, 23)
        Me.Add.TabIndex = 46
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = True
        '
        'Clients_Food_Ordering_File
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 581)
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
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.Description)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ClientID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Quantity)
        Me.Controls.Add(Me.OrderNumber)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Clients_Food_Ordering_File"
        Me.Text = "Clients_Food_Ordering_File"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Description As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ClientID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Quantity As System.Windows.Forms.TextBox
    Friend WithEvents OrderNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents Previous As System.Windows.Forms.Button
    Friend WithEvents First As System.Windows.Forms.Button
    Friend WithEvents Openreport As System.Windows.Forms.Button
    Friend WithEvents Nextbtn As System.Windows.Forms.Button
    Friend WithEvents Last As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Add As System.Windows.Forms.Button
End Class
