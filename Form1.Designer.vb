Imports System.IO

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.PlayCol = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.IconCol = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TitleCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LPOCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPTCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IOCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RatingCol = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(191, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(534, 53)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total: 1 games"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(312, 20)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(174, 20)
        Me.ComboBox1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 408)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(716, 100)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(708, 74)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Overview"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(708, 74)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Stats"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(708, 74)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Performance"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PlayCol, Me.IconCol, Me.TitleCol, Me.CategoryCol, Me.LPOCol, Me.TPTCol, Me.IOCol, Me.RatingCol})
        Me.DGV.Location = New System.Drawing.Point(16, 160)
        Me.DGV.Name = "DGV"
        Me.DGV.RowTemplate.Height = 23
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(706, 242)
        Me.DGV.TabIndex = 16
        '
        'PlayCol
        '
        Me.PlayCol.HeaderText = ""
        Me.PlayCol.Name = "PlayCol"
        Me.PlayCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PlayCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PlayCol.UseColumnTextForButtonValue = True
        Me.PlayCol.Width = 40
        '
        'IconCol
        '
        Me.IconCol.HeaderText = "Icon"
        Me.IconCol.Name = "IconCol"
        Me.IconCol.Width = 35
        '
        'TitleCol
        '
        Me.TitleCol.HeaderText = "Title"
        Me.TitleCol.Name = "TitleCol"
        '
        'CategoryCol
        '
        Me.CategoryCol.HeaderText = "Category"
        Me.CategoryCol.Name = "CategoryCol"
        Me.CategoryCol.Width = 80
        '
        'LPOCol
        '
        Me.LPOCol.HeaderText = "Last Played On"
        Me.LPOCol.Name = "LPOCol"
        '
        'TPTCol
        '
        Me.TPTCol.HeaderText = "Total Play Time"
        Me.TPTCol.Name = "TPTCol"
        '
        'IOCol
        '
        Me.IOCol.HeaderText = "Installed On"
        Me.IOCol.Name = "IOCol"
        '
        'RatingCol
        '
        Me.RatingCol.HeaderText = "Rating"
        Me.RatingCol.Name = "RatingCol"
        Me.RatingCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RatingCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("SimSun", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button8.Image = Global.WindowsApplication1.My.Resources.Resources.uninstall
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button8.Location = New System.Drawing.Point(343, 12)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(70, 70)
        Me.Button8.TabIndex = 15
        Me.Button8.Text = "Uninstall"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources.Search
        Me.Button1.Location = New System.Drawing.Point(492, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("SimSun", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button7.Image = Global.WindowsApplication1.My.Resources.Resources.delete
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.Location = New System.Drawing.Point(267, 12)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(70, 70)
        Me.Button7.TabIndex = 11
        Me.Button7.Text = "Delete"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("SimSun", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button6.Image = Global.WindowsApplication1.My.Resources.Resources.control_settings
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.Location = New System.Drawing.Point(579, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(70, 70)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "Settings"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("SimSun", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button5.Image = Global.WindowsApplication1.My.Resources.Resources.help
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(655, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(70, 70)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Help"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("SimSun", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button4.Image = Global.WindowsApplication1.My.Resources.Resources.alert
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(503, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(70, 70)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Alert"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("SimSun", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button3.Image = Global.WindowsApplication1.My.Resources.Resources.add_file_icon
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(191, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(70, 70)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Add"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button2.Image = Global.WindowsApplication1.My.Resources.Resources.play
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(12, 7)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 100)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Play"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 512)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "GameManager"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Private Sub AddRow(ByVal pic1 As String, ByVal pic2 As String, ByVal title As String, ByVal cat As String, ByVal last As String, ByVal hrs As String, ByVal first As String)
        Dim path As String = Application.StartupPath & pic1
        Dim rpath As String = Application.StartupPath & pic2
        Dim file As FileStream = New FileStream(path, FileMode.Open)
        Dim rfile As FileStream = New FileStream(rpath, FileMode.Open)
        Dim pic As Image = Image.FromStream(file)
        Dim rpic As Image = Image.FromStream(rfile)
        file.Close()
        rfile.Close()
        DGV.Rows.Add("", pic, title, cat, last, hrs, first, rpic)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PlayCol.Text = "play"
        AddRow("/ab.gif", "/stars.gif", "Angry Bird", "PUZ", "12/1/2011", "50h", "10/1/2011")
        AddRow("/cs.png", "/stars.gif", "Counter Strike", "STG", "1/11/2012", "100h", "5/1/2011")
        AddRow("/fifa12.jpg", "/stars.gif", "FIFA12", "SPT", "11/1/2011", "30h", "10/1/2011")
    End Sub

    Friend WithEvents PlayCol As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents IconCol As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents TitleCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LPOCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPTCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IOCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RatingCol As System.Windows.Forms.DataGridViewImageColumn

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick
        Dim CIndex As Integer = e.ColumnIndex
        If (CIndex = 0) Then
            Form2.Show()
        End If
    End Sub

    Private Sub DGV_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellDoubleClick
        Form2.Show()
    End Sub
End Class
