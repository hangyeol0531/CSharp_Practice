<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbOk = New System.Windows.Forms.RadioButton()
        Me.rbOkCancel = New System.Windows.Forms.RadioButton()
        Me.rbYesNo = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbquestion = New System.Windows.Forms.RadioButton()
        Me.rbInformation = New System.Windows.Forms.RadioButton()
        Me.rbError = New System.Windows.Forms.RadioButton()
        Me.btenShow = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbYesNo)
        Me.GroupBox1.Controls.Add(Me.rbOkCancel)
        Me.GroupBox1.Controls.Add(Me.rbOk)
        Me.GroupBox1.Location = New System.Drawing.Point(63, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 117)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type"
        '
        'rbOk
        '
        Me.rbOk.AutoSize = True
        Me.rbOk.Location = New System.Drawing.Point(6, 31)
        Me.rbOk.Name = "rbOk"
        Me.rbOk.Size = New System.Drawing.Size(40, 16)
        Me.rbOk.TabIndex = 0
        Me.rbOk.TabStop = True
        Me.rbOk.Text = "OK"
        Me.rbOk.UseVisualStyleBackColor = True
        '
        'rbOkCancel
        '
        Me.rbOkCancel.AutoSize = True
        Me.rbOkCancel.Location = New System.Drawing.Point(6, 53)
        Me.rbOkCancel.Name = "rbOkCancel"
        Me.rbOkCancel.Size = New System.Drawing.Size(80, 16)
        Me.rbOkCancel.TabIndex = 1
        Me.rbOkCancel.TabStop = True
        Me.rbOkCancel.Text = "OKCancel"
        Me.rbOkCancel.UseVisualStyleBackColor = True
        '
        'rbYesNo
        '
        Me.rbYesNo.AutoSize = True
        Me.rbYesNo.Location = New System.Drawing.Point(6, 75)
        Me.rbYesNo.Name = "rbYesNo"
        Me.rbYesNo.Size = New System.Drawing.Size(61, 16)
        Me.rbYesNo.TabIndex = 2
        Me.rbYesNo.TabStop = True
        Me.rbYesNo.Text = "YesNo"
        Me.rbYesNo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbquestion)
        Me.GroupBox2.Controls.Add(Me.rbInformation)
        Me.GroupBox2.Controls.Add(Me.rbError)
        Me.GroupBox2.Location = New System.Drawing.Point(364, 46)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 117)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Icon"
        '
        'rbquestion
        '
        Me.rbquestion.AutoSize = True
        Me.rbquestion.Location = New System.Drawing.Point(6, 75)
        Me.rbquestion.Name = "rbquestion"
        Me.rbquestion.Size = New System.Drawing.Size(71, 16)
        Me.rbquestion.TabIndex = 2
        Me.rbquestion.TabStop = True
        Me.rbquestion.Text = "question"
        Me.rbquestion.UseVisualStyleBackColor = True
        '
        'rbInformation
        '
        Me.rbInformation.AutoSize = True
        Me.rbInformation.Location = New System.Drawing.Point(6, 53)
        Me.rbInformation.Name = "rbInformation"
        Me.rbInformation.Size = New System.Drawing.Size(85, 16)
        Me.rbInformation.TabIndex = 1
        Me.rbInformation.TabStop = True
        Me.rbInformation.Text = "Information"
        Me.rbInformation.UseVisualStyleBackColor = True
        '
        'rbError
        '
        Me.rbError.AutoSize = True
        Me.rbError.Location = New System.Drawing.Point(6, 31)
        Me.rbError.Name = "rbError"
        Me.rbError.Size = New System.Drawing.Size(50, 16)
        Me.rbError.TabIndex = 0
        Me.rbError.TabStop = True
        Me.rbError.Text = "Error"
        Me.rbError.UseVisualStyleBackColor = True
        '
        'btenShow
        '
        Me.btenShow.Location = New System.Drawing.Point(634, 311)
        Me.btenShow.Name = "btenShow"
        Me.btenShow.Size = New System.Drawing.Size(85, 35)
        Me.btenShow.TabIndex = 2
        Me.btenShow.Text = "Show"
        Me.btenShow.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 430)
        Me.Controls.Add(Me.btenShow)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbYesNo As RadioButton
    Friend WithEvents rbOkCancel As RadioButton
    Friend WithEvents rbOk As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbquestion As RadioButton
    Friend WithEvents rbInformation As RadioButton
    Friend WithEvents rbError As RadioButton
    Friend WithEvents btenShow As Button
End Class
