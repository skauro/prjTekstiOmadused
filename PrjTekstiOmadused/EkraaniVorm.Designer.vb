<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EkraaniVorm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblSisend = New System.Windows.Forms.Label()
        Me.btnPoora = New System.Windows.Forms.Button()
        Me.txtSisendTekst = New System.Windows.Forms.TextBox()
        Me.lblPooratud = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTaishaalikuid = New System.Windows.Forms.TextBox()
        Me.txtPooratudTekst = New System.Windows.Forms.TextBox()
        Me.txtPalindroom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTahemargid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblSisend
        '
        Me.lblSisend.AutoSize = True
        Me.lblSisend.Location = New System.Drawing.Point(93, 37)
        Me.lblSisend.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSisend.Name = "lblSisend"
        Me.lblSisend.Size = New System.Drawing.Size(58, 20)
        Me.lblSisend.TabIndex = 0
        Me.lblSisend.Text = "Sisend"
        '
        'btnPoora
        '
        Me.btnPoora.Location = New System.Drawing.Point(160, 72)
        Me.btnPoora.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPoora.Name = "btnPoora"
        Me.btnPoora.Size = New System.Drawing.Size(222, 35)
        Me.btnPoora.TabIndex = 1
        Me.btnPoora.Text = "Lahenda!"
        Me.btnPoora.UseVisualStyleBackColor = True
        '
        'txtSisendTekst
        '
        Me.txtSisendTekst.Location = New System.Drawing.Point(160, 32)
        Me.txtSisendTekst.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSisendTekst.Name = "txtSisendTekst"
        Me.txtSisendTekst.Size = New System.Drawing.Size(220, 26)
        Me.txtSisendTekst.TabIndex = 2
        '
        'lblPooratud
        '
        Me.lblPooratud.AutoSize = True
        Me.lblPooratud.Location = New System.Drawing.Point(39, 123)
        Me.lblPooratud.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPooratud.Name = "lblPooratud"
        Me.lblPooratud.Size = New System.Drawing.Size(117, 20)
        Me.lblPooratud.TabIndex = 3
        Me.lblPooratud.Text = "Pööratud tekst:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 163)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Täishäälikuid:"
        '
        'txtTaishaalikuid
        '
        Me.txtTaishaalikuid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTaishaalikuid.Location = New System.Drawing.Point(160, 157)
        Me.txtTaishaalikuid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTaishaalikuid.Name = "txtTaishaalikuid"
        Me.txtTaishaalikuid.ReadOnly = True
        Me.txtTaishaalikuid.Size = New System.Drawing.Size(221, 26)
        Me.txtTaishaalikuid.TabIndex = 6
        '
        'txtPooratudTekst
        '
        Me.txtPooratudTekst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPooratudTekst.Location = New System.Drawing.Point(160, 117)
        Me.txtPooratudTekst.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPooratudTekst.Name = "txtPooratudTekst"
        Me.txtPooratudTekst.ReadOnly = True
        Me.txtPooratudTekst.Size = New System.Drawing.Size(221, 26)
        Me.txtPooratudTekst.TabIndex = 7
        '
        'txtPalindroom
        '
        Me.txtPalindroom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPalindroom.Location = New System.Drawing.Point(160, 197)
        Me.txtPalindroom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPalindroom.Name = "txtPalindroom"
        Me.txtPalindroom.ReadOnly = True
        Me.txtPalindroom.Size = New System.Drawing.Size(221, 26)
        Me.txtPalindroom.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 200)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Palindroom:"
        '
        'txtTahemargid
        '
        Me.txtTahemargid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTahemargid.Location = New System.Drawing.Point(160, 237)
        Me.txtTahemargid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTahemargid.Name = "txtTahemargid"
        Me.txtTahemargid.ReadOnly = True
        Me.txtTahemargid.Size = New System.Drawing.Size(221, 26)
        Me.txtTahemargid.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 240)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Tahemärgid ette"
        '
        'EkraaniVorm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 723)
        Me.Controls.Add(Me.txtTahemargid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPalindroom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPooratudTekst)
        Me.Controls.Add(Me.txtTaishaalikuid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPooratud)
        Me.Controls.Add(Me.txtSisendTekst)
        Me.Controls.Add(Me.btnPoora)
        Me.Controls.Add(Me.lblSisend)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "EkraaniVorm"
        Me.Text = "Teksti töötleja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSisend As Label
    Friend WithEvents btnPoora As Button
    Friend WithEvents txtSisendTekst As TextBox
    Friend WithEvents lblPooratud As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTaishaalikuid As TextBox
    Friend WithEvents txtPooratudTekst As TextBox
    Friend WithEvents txtPalindroom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTahemargid As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
