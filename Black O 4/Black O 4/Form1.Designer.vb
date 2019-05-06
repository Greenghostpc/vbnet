<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim Specialist_CallsignLabel As System.Windows.Forms.Label
        Dim EquiptmentLabel As System.Windows.Forms.Label
        Dim AbilityLabel As System.Windows.Forms.Label
        Dim Black_Ops_3_Label As System.Windows.Forms.Label
        Me.Bo4yesDataSet = New Black_O_4.Bo4yesDataSet()
        Me.TblBO4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblBO4TableAdapter = New Black_O_4.Bo4yesDataSetTableAdapters.tblBO4TableAdapter()
        Me.TableAdapterManager = New Black_O_4.Bo4yesDataSetTableAdapters.TableAdapterManager()
        Me.TblBO4BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TblBO4BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Specialist_CallsignTextBox = New System.Windows.Forms.TextBox()
        Me.EquiptmentTextBox = New System.Windows.Forms.TextBox()
        Me.AbilityTextBox = New System.Windows.Forms.TextBox()
        Me.Black_Ops_3_CheckBox = New System.Windows.Forms.CheckBox()
        Specialist_CallsignLabel = New System.Windows.Forms.Label()
        EquiptmentLabel = New System.Windows.Forms.Label()
        AbilityLabel = New System.Windows.Forms.Label()
        Black_Ops_3_Label = New System.Windows.Forms.Label()
        CType(Me.Bo4yesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBO4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBO4BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblBO4BindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bo4yesDataSet
        '
        Me.Bo4yesDataSet.DataSetName = "Bo4yesDataSet"
        Me.Bo4yesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblBO4BindingSource
        '
        Me.TblBO4BindingSource.DataMember = "tblBO4"
        Me.TblBO4BindingSource.DataSource = Me.Bo4yesDataSet
        '
        'TblBO4TableAdapter
        '
        Me.TblBO4TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblBO4TableAdapter = Me.TblBO4TableAdapter
        Me.TableAdapterManager.UpdateOrder = Black_O_4.Bo4yesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblBO4BindingNavigator
        '
        Me.TblBO4BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblBO4BindingNavigator.BindingSource = Me.TblBO4BindingSource
        Me.TblBO4BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblBO4BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblBO4BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblBO4BindingNavigatorSaveItem})
        Me.TblBO4BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblBO4BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblBO4BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblBO4BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblBO4BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblBO4BindingNavigator.Name = "TblBO4BindingNavigator"
        Me.TblBO4BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblBO4BindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.TblBO4BindingNavigator.TabIndex = 0
        Me.TblBO4BindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'TblBO4BindingNavigatorSaveItem
        '
        Me.TblBO4BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblBO4BindingNavigatorSaveItem.Image = CType(resources.GetObject("TblBO4BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblBO4BindingNavigatorSaveItem.Name = "TblBO4BindingNavigatorSaveItem"
        Me.TblBO4BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblBO4BindingNavigatorSaveItem.Text = "Save Data"
        '
        'Specialist_CallsignLabel
        '
        Specialist_CallsignLabel.AutoSize = True
        Specialist_CallsignLabel.Location = New System.Drawing.Point(73, 67)
        Specialist_CallsignLabel.Name = "Specialist_CallsignLabel"
        Specialist_CallsignLabel.Size = New System.Drawing.Size(94, 13)
        Specialist_CallsignLabel.TabIndex = 1
        Specialist_CallsignLabel.Text = "Specialist Callsign:"
        '
        'Specialist_CallsignTextBox
        '
        Me.Specialist_CallsignTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBO4BindingSource, "Specialist Callsign", True))
        Me.Specialist_CallsignTextBox.Location = New System.Drawing.Point(173, 64)
        Me.Specialist_CallsignTextBox.Name = "Specialist_CallsignTextBox"
        Me.Specialist_CallsignTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Specialist_CallsignTextBox.TabIndex = 2
        '
        'EquiptmentLabel
        '
        EquiptmentLabel.AutoSize = True
        EquiptmentLabel.Location = New System.Drawing.Point(104, 93)
        EquiptmentLabel.Name = "EquiptmentLabel"
        EquiptmentLabel.Size = New System.Drawing.Size(63, 13)
        EquiptmentLabel.TabIndex = 3
        EquiptmentLabel.Text = "Equiptment:"
        '
        'EquiptmentTextBox
        '
        Me.EquiptmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBO4BindingSource, "Equiptment", True))
        Me.EquiptmentTextBox.Location = New System.Drawing.Point(173, 90)
        Me.EquiptmentTextBox.Name = "EquiptmentTextBox"
        Me.EquiptmentTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EquiptmentTextBox.TabIndex = 4
        '
        'AbilityLabel
        '
        AbilityLabel.AutoSize = True
        AbilityLabel.Location = New System.Drawing.Point(130, 119)
        AbilityLabel.Name = "AbilityLabel"
        AbilityLabel.Size = New System.Drawing.Size(37, 13)
        AbilityLabel.TabIndex = 5
        AbilityLabel.Text = "Ability:"
        '
        'AbilityTextBox
        '
        Me.AbilityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBO4BindingSource, "Ability", True))
        Me.AbilityTextBox.Location = New System.Drawing.Point(173, 116)
        Me.AbilityTextBox.Name = "AbilityTextBox"
        Me.AbilityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AbilityTextBox.TabIndex = 6
        '
        'Black_Ops_3_Label
        '
        Black_Ops_3_Label.AutoSize = True
        Black_Ops_3_Label.Location = New System.Drawing.Point(93, 146)
        Black_Ops_3_Label.Name = "Black_Ops_3_Label"
        Black_Ops_3_Label.Size = New System.Drawing.Size(74, 13)
        Black_Ops_3_Label.TabIndex = 7
        Black_Ops_3_Label.Text = "Black Ops 3?:"
        '
        'Black_Ops_3_CheckBox
        '
        Me.Black_Ops_3_CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblBO4BindingSource, "Black Ops 3?", True))
        Me.Black_Ops_3_CheckBox.Location = New System.Drawing.Point(173, 141)
        Me.Black_Ops_3_CheckBox.Name = "Black_Ops_3_CheckBox"
        Me.Black_Ops_3_CheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Black_Ops_3_CheckBox.TabIndex = 8
        Me.Black_Ops_3_CheckBox.Text = "CheckBox1"
        Me.Black_Ops_3_CheckBox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Black_Ops_3_Label)
        Me.Controls.Add(Me.Black_Ops_3_CheckBox)
        Me.Controls.Add(AbilityLabel)
        Me.Controls.Add(Me.AbilityTextBox)
        Me.Controls.Add(EquiptmentLabel)
        Me.Controls.Add(Me.EquiptmentTextBox)
        Me.Controls.Add(Specialist_CallsignLabel)
        Me.Controls.Add(Me.Specialist_CallsignTextBox)
        Me.Controls.Add(Me.TblBO4BindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Bo4yesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBO4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBO4BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblBO4BindingNavigator.ResumeLayout(False)
        Me.TblBO4BindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bo4yesDataSet As Bo4yesDataSet
    Friend WithEvents TblBO4BindingSource As BindingSource
    Friend WithEvents TblBO4TableAdapter As Bo4yesDataSetTableAdapters.tblBO4TableAdapter
    Friend WithEvents TableAdapterManager As Bo4yesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblBO4BindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TblBO4BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Specialist_CallsignTextBox As TextBox
    Friend WithEvents EquiptmentTextBox As TextBox
    Friend WithEvents AbilityTextBox As TextBox
    Friend WithEvents Black_Ops_3_CheckBox As CheckBox
End Class
