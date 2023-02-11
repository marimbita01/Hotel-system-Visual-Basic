Public Class Invetory_Management_File

    Private Sub Add_Click(sender As System.Object, e As System.EventArgs) Handles Add.Click

    End Sub

    Private Sub Clients_Booking_FileBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles Clients_Booking_FileBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Clients_Booking_FileBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HopeFayHotel_DataSet)

    End Sub

    Private Sub Invetory_Management_File_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HopeFayHotel_DataSet.Clients_Booking_File' table. You can move, or remove it, as needed.
        Me.Clients_Booking_FileTableAdapter.Fill(Me.HopeFayHotel_DataSet.Clients_Booking_File)

    End Sub
End Class