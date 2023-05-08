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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnVeg = New System.Windows.Forms.Button()
        Me.btnSeafood = New System.Windows.Forms.Button()
        Me.btnBeef = New System.Windows.Forms.Button()
        Me.grpRadio = New System.Windows.Forms.GroupBox()
        Me.rbtnNone = New System.Windows.Forms.RadioButton()
        Me.rbtnCombo = New System.Windows.Forms.RadioButton()
        Me.rbtnDrink = New System.Windows.Forms.RadioButton()
        Me.rbtnSide = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.picBeef = New System.Windows.Forms.PictureBox()
        Me.picVeggie = New System.Windows.Forms.PictureBox()
        Me.picSeafood = New System.Windows.Forms.PictureBox()
        Me.lblCalculator = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblHowMany = New System.Windows.Forms.Label()
        Me.txtPeople = New System.Windows.Forms.TextBox()
        Me.grpRadio.SuspendLayout()
        CType(Me.picBeef, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVeggie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSeafood, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVeg
        '
        Me.btnVeg.BackColor = System.Drawing.Color.DarkRed
        Me.btnVeg.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeg.Location = New System.Drawing.Point(140, 193)
        Me.btnVeg.Name = "btnVeg"
        Me.btnVeg.Size = New System.Drawing.Size(90, 46)
        Me.btnVeg.TabIndex = 0
        Me.btnVeg.Text = "Vegetarian"
        Me.btnVeg.UseVisualStyleBackColor = False
        '
        'btnSeafood
        '
        Me.btnSeafood.BackColor = System.Drawing.Color.DarkRed
        Me.btnSeafood.Font = New System.Drawing.Font("Franklin Gothic Heavy", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeafood.Location = New System.Drawing.Point(315, 193)
        Me.btnSeafood.Name = "btnSeafood"
        Me.btnSeafood.Size = New System.Drawing.Size(90, 46)
        Me.btnSeafood.TabIndex = 1
        Me.btnSeafood.Text = "Seafood"
        Me.btnSeafood.UseVisualStyleBackColor = False
        '
        'btnBeef
        '
        Me.btnBeef.BackColor = System.Drawing.Color.DarkRed
        Me.btnBeef.Font = New System.Drawing.Font("Franklin Gothic Heavy", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBeef.Location = New System.Drawing.Point(493, 193)
        Me.btnBeef.Name = "btnBeef"
        Me.btnBeef.Size = New System.Drawing.Size(90, 46)
        Me.btnBeef.TabIndex = 2
        Me.btnBeef.Text = "Beef"
        Me.btnBeef.UseVisualStyleBackColor = False
        '
        'grpRadio
        '
        Me.grpRadio.BackColor = System.Drawing.Color.DarkRed
        Me.grpRadio.Controls.Add(Me.rbtnNone)
        Me.grpRadio.Controls.Add(Me.rbtnCombo)
        Me.grpRadio.Controls.Add(Me.rbtnDrink)
        Me.grpRadio.Controls.Add(Me.rbtnSide)
        Me.grpRadio.Location = New System.Drawing.Point(211, 263)
        Me.grpRadio.Name = "grpRadio"
        Me.grpRadio.Size = New System.Drawing.Size(280, 114)
        Me.grpRadio.TabIndex = 3
        Me.grpRadio.TabStop = False
        '
        'rbtnNone
        '
        Me.rbtnNone.AutoSize = True
        Me.rbtnNone.Checked = True
        Me.rbtnNone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnNone.Location = New System.Drawing.Point(7, 82)
        Me.rbtnNone.Name = "rbtnNone"
        Me.rbtnNone.Size = New System.Drawing.Size(63, 20)
        Me.rbtnNone.TabIndex = 3
        Me.rbtnNone.TabStop = True
        Me.rbtnNone.Text = "None"
        Me.rbtnNone.UseVisualStyleBackColor = True
        '
        'rbtnCombo
        '
        Me.rbtnCombo.AutoSize = True
        Me.rbtnCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnCombo.Location = New System.Drawing.Point(7, 60)
        Me.rbtnCombo.Name = "rbtnCombo"
        Me.rbtnCombo.Size = New System.Drawing.Size(195, 20)
        Me.rbtnCombo.TabIndex = 2
        Me.rbtnCombo.TabStop = True
        Me.rbtnCombo.Text = "Add a side + drink: $2.50"
        Me.rbtnCombo.UseVisualStyleBackColor = True
        '
        'rbtnDrink
        '
        Me.rbtnDrink.AutoSize = True
        Me.rbtnDrink.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnDrink.Location = New System.Drawing.Point(7, 36)
        Me.rbtnDrink.Name = "rbtnDrink"
        Me.rbtnDrink.Size = New System.Drawing.Size(149, 20)
        Me.rbtnDrink.TabIndex = 1
        Me.rbtnDrink.TabStop = True
        Me.rbtnDrink.Text = "Add a drink: $1.50"
        Me.rbtnDrink.UseVisualStyleBackColor = True
        '
        'rbtnSide
        '
        Me.rbtnSide.AutoSize = True
        Me.rbtnSide.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnSide.Location = New System.Drawing.Point(7, 13)
        Me.rbtnSide.Name = "rbtnSide"
        Me.rbtnSide.Size = New System.Drawing.Size(133, 20)
        Me.rbtnSide.TabIndex = 0
        Me.rbtnSide.TabStop = True
        Me.rbtnSide.Text = "Add a side:   $1"
        Me.rbtnSide.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.DarkRed
        Me.btnCalculate.Font = New System.Drawing.Font("Franklin Gothic Heavy", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(383, 457)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(108, 46)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.SystemColors.Control
        Me.lblPrice.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.DarkRed
        Me.lblPrice.Location = New System.Drawing.Point(29, 517)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(0, 24)
        Me.lblPrice.TabIndex = 5
        '
        'picBeef
        '
        Me.picBeef.BackgroundImage = CType(resources.GetObject("picBeef.BackgroundImage"), System.Drawing.Image)
        Me.picBeef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBeef.Location = New System.Drawing.Point(267, 24)
        Me.picBeef.Name = "picBeef"
        Me.picBeef.Size = New System.Drawing.Size(195, 146)
        Me.picBeef.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBeef.TabIndex = 6
        Me.picBeef.TabStop = False
        Me.picBeef.Visible = False
        '
        'picVeggie
        '
        Me.picVeggie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picVeggie.Image = CType(resources.GetObject("picVeggie.Image"), System.Drawing.Image)
        Me.picVeggie.Location = New System.Drawing.Point(267, 24)
        Me.picVeggie.Name = "picVeggie"
        Me.picVeggie.Size = New System.Drawing.Size(195, 146)
        Me.picVeggie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVeggie.TabIndex = 7
        Me.picVeggie.TabStop = False
        Me.picVeggie.Visible = False
        '
        'picSeafood
        '
        Me.picSeafood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picSeafood.Image = CType(resources.GetObject("picSeafood.Image"), System.Drawing.Image)
        Me.picSeafood.Location = New System.Drawing.Point(267, 24)
        Me.picSeafood.Name = "picSeafood"
        Me.picSeafood.Size = New System.Drawing.Size(195, 146)
        Me.picSeafood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSeafood.TabIndex = 8
        Me.picSeafood.TabStop = False
        Me.picSeafood.Visible = False
        '
        'lblCalculator
        '
        Me.lblCalculator.AutoSize = True
        Me.lblCalculator.BackColor = System.Drawing.Color.Transparent
        Me.lblCalculator.Font = New System.Drawing.Font("Franklin Gothic Heavy", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculator.ForeColor = System.Drawing.Color.DarkRed
        Me.lblCalculator.Location = New System.Drawing.Point(204, 80)
        Me.lblCalculator.Name = "lblCalculator"
        Me.lblCalculator.Size = New System.Drawing.Size(347, 74)
        Me.lblCalculator.TabIndex = 9
        Me.lblCalculator.Text = "Food Calculator" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please select an option!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblCalculator.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DarkRed
        Me.btnClear.Font = New System.Drawing.Font("Franklin Gothic Heavy", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(211, 457)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(108, 46)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblHowMany
        '
        Me.lblHowMany.AutoSize = True
        Me.lblHowMany.BackColor = System.Drawing.Color.Transparent
        Me.lblHowMany.Font = New System.Drawing.Font("Franklin Gothic Heavy", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHowMany.ForeColor = System.Drawing.Color.DarkRed
        Me.lblHowMany.Location = New System.Drawing.Point(207, 408)
        Me.lblHowMany.Name = "lblHowMany"
        Me.lblHowMany.Size = New System.Drawing.Size(169, 20)
        Me.lblHowMany.TabIndex = 11
        Me.lblHowMany.Text = "For how many people?"
        '
        'txtPeople
        '
        Me.txtPeople.Font = New System.Drawing.Font("Franklin Gothic Heavy", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeople.Location = New System.Drawing.Point(426, 408)
        Me.txtPeople.Name = "txtPeople"
        Me.txtPeople.Size = New System.Drawing.Size(36, 25)
        Me.txtPeople.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(713, 560)
        Me.Controls.Add(Me.txtPeople)
        Me.Controls.Add(Me.lblHowMany)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblCalculator)
        Me.Controls.Add(Me.picSeafood)
        Me.Controls.Add(Me.picVeggie)
        Me.Controls.Add(Me.picBeef)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpRadio)
        Me.Controls.Add(Me.btnBeef)
        Me.Controls.Add(Me.btnSeafood)
        Me.Controls.Add(Me.btnVeg)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Food Cost Calculator"
        Me.grpRadio.ResumeLayout(False)
        Me.grpRadio.PerformLayout()
        CType(Me.picBeef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVeggie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSeafood, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVeg As Button
    Friend WithEvents btnSeafood As Button
    Friend WithEvents btnBeef As Button
    Friend WithEvents grpRadio As GroupBox
    Friend WithEvents rbtnCombo As RadioButton
    Friend WithEvents rbtnDrink As RadioButton
    Friend WithEvents rbtnSide As RadioButton
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblPrice As Label
    Friend WithEvents picBeef As PictureBox
    Friend WithEvents picVeggie As PictureBox
    Friend WithEvents picSeafood As PictureBox
    Friend WithEvents lblCalculator As Label
    Friend WithEvents rbtnNone As RadioButton
    Friend WithEvents btnClear As Button
    Friend WithEvents lblHowMany As Label
    Friend WithEvents txtPeople As TextBox
End Class
