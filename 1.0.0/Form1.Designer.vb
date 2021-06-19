<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Ans = New System.Windows.Forms.Label
        Me.T1 = New System.Windows.Forms.TextBox
        Me.T2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tasu = New System.Windows.Forms.Button
        Me.mainasu = New System.Windows.Forms.Button
        Me.kakeru = New System.Windows.Forms.Button
        Me.waru = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.kigou = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Ans
        '
        Me.Ans.Location = New System.Drawing.Point(206, 38)
        Me.Ans.Name = "Ans"
        Me.Ans.Size = New System.Drawing.Size(76, 19)
        Me.Ans.TabIndex = 0
        '
        'T1
        '
        Me.T1.Location = New System.Drawing.Point(12, 38)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(72, 19)
        Me.T1.TabIndex = 1
        '
        'T2
        '
        Me.T2.Location = New System.Drawing.Point(108, 38)
        Me.T2.Name = "T2"
        Me.T2.Size = New System.Drawing.Size(71, 19)
        Me.T2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(106, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 12)
        Me.Label3.TabIndex = 4
        '
        'tasu
        '
        Me.tasu.Location = New System.Drawing.Point(12, 147)
        Me.tasu.Name = "tasu"
        Me.tasu.Size = New System.Drawing.Size(75, 23)
        Me.tasu.TabIndex = 5
        Me.tasu.Text = "＋"
        Me.tasu.UseVisualStyleBackColor = True
        '
        'mainasu
        '
        Me.mainasu.Location = New System.Drawing.Point(93, 147)
        Me.mainasu.Name = "mainasu"
        Me.mainasu.Size = New System.Drawing.Size(75, 23)
        Me.mainasu.TabIndex = 6
        Me.mainasu.Text = "－"
        Me.mainasu.UseVisualStyleBackColor = True
        '
        'kakeru
        '
        Me.kakeru.Location = New System.Drawing.Point(93, 176)
        Me.kakeru.Name = "kakeru"
        Me.kakeru.Size = New System.Drawing.Size(75, 23)
        Me.kakeru.TabIndex = 7
        Me.kakeru.Text = "÷"
        Me.kakeru.UseVisualStyleBackColor = True
        '
        'waru
        '
        Me.waru.Location = New System.Drawing.Point(12, 176)
        Me.waru.Name = "waru"
        Me.waru.Size = New System.Drawing.Size(75, 23)
        Me.waru.TabIndex = 8
        Me.waru.Text = "×"
        Me.waru.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(189, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "="
        '
        'kigou
        '
        Me.kigou.Location = New System.Drawing.Point(91, 38)
        Me.kigou.Name = "kigou"
        Me.kigou.Size = New System.Drawing.Size(17, 15)
        Me.kigou.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.kigou)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.waru)
        Me.Controls.Add(Me.kakeru)
        Me.Controls.Add(Me.mainasu)
        Me.Controls.Add(Me.tasu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.T2)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.Ans)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "キーボード電卓"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ans As System.Windows.Forms.Label
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents T2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tasu As System.Windows.Forms.Button
    Friend WithEvents mainasu As System.Windows.Forms.Button
    Friend WithEvents kakeru As System.Windows.Forms.Button
    Friend WithEvents waru As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents kigou As System.Windows.Forms.Label

End Class
