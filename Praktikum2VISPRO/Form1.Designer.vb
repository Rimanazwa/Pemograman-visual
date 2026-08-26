<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtnama = New TextBox()
        txtnim = New TextBox()
        txtkom = New TextBox()
        btntampilkan = New Button()
        btnhapus = New Button()
        btnkeluar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(176, 130)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 20)
        Label1.TabIndex = 0
        Label1.Text = "NAMA   :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(176, 164)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 20)
        Label2.TabIndex = 1
        Label2.Text = "NIM       :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(176, 199)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 20)
        Label3.TabIndex = 2
        Label3.Text = "KOM      :"
        ' 
        ' txtnama
        ' 
        txtnama.Location = New Point(250, 127)
        txtnama.Name = "txtnama"
        txtnama.Size = New Size(125, 27)
        txtnama.TabIndex = 3
        ' 
        ' txtnim
        ' 
        txtnim.Location = New Point(250, 161)
        txtnim.Name = "txtnim"
        txtnim.Size = New Size(125, 27)
        txtnim.TabIndex = 4
        ' 
        ' txtkom
        ' 
        txtkom.Location = New Point(250, 196)
        txtkom.Name = "txtkom"
        txtkom.Size = New Size(125, 27)
        txtkom.TabIndex = 5
        ' 
        ' btntampilkan
        ' 
        btntampilkan.Location = New Point(176, 239)
        btntampilkan.Name = "btntampilkan"
        btntampilkan.Size = New Size(94, 29)
        btntampilkan.TabIndex = 6
        btntampilkan.Text = "Tampilkan"
        btntampilkan.UseVisualStyleBackColor = True
        ' 
        ' btnhapus
        ' 
        btnhapus.Location = New Point(281, 239)
        btnhapus.Name = "btnhapus"
        btnhapus.Size = New Size(94, 29)
        btnhapus.TabIndex = 7
        btnhapus.Text = "Hapus"
        btnhapus.UseVisualStyleBackColor = True
        ' 
        ' btnkeluar
        ' 
        btnkeluar.Location = New Point(233, 274)
        btnkeluar.Name = "btnkeluar"
        btnkeluar.Size = New Size(94, 29)
        btnkeluar.TabIndex = 8
        btnkeluar.Text = "Keluar"
        btnkeluar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1083, 572)
        Controls.Add(btnkeluar)
        Controls.Add(btnhapus)
        Controls.Add(btntampilkan)
        Controls.Add(txtkom)
        Controls.Add(txtnim)
        Controls.Add(txtnama)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnama As TextBox
    Friend WithEvents txtnim As TextBox
    Friend WithEvents txtkom As TextBox
    Friend WithEvents btntampilkan As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnkeluar As Button

End Class
