<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gBrowser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gBrowser))
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.addressBox = New System.Windows.Forms.TextBox()
        Me.GoBtn = New System.Windows.Forms.Button()
        Me.Home = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 28)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1637, 771)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("http://www.duckduckgo.com", System.UriKind.Absolute)
        '
        'addressBox
        '
        Me.addressBox.Location = New System.Drawing.Point(8, 2)
        Me.addressBox.Name = "addressBox"
        Me.addressBox.Size = New System.Drawing.Size(1509, 20)
        Me.addressBox.TabIndex = 2
        '
        'GoBtn
        '
        Me.GoBtn.Location = New System.Drawing.Point(1523, 0)
        Me.GoBtn.Name = "GoBtn"
        Me.GoBtn.Size = New System.Drawing.Size(31, 23)
        Me.GoBtn.TabIndex = 3
        Me.GoBtn.Text = "Go"
        Me.GoBtn.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.Home.Location = New System.Drawing.Point(1560, 0)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(57, 23)
        Me.Home.TabIndex = 4
        Me.Home.Text = "Home"
        Me.Home.UseVisualStyleBackColor = True
        '
        'gBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1639, 805)
        Me.Controls.Add(Me.Home)
        Me.Controls.Add(Me.GoBtn)
        Me.Controls.Add(Me.addressBox)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "gBrowser"
        Me.Text = "gBrowser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents addressBox As System.Windows.Forms.TextBox
    Friend WithEvents GoBtn As System.Windows.Forms.Button
    Friend WithEvents Home As System.Windows.Forms.Button

End Class
