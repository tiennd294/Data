Imports HAPI
Public Class Form1
    Inherits System.Windows.Forms.Form
    Dim d As Domain
    Dim glob As New Globals
    Private Const MurderYes = 0
    Private Const MurderNo = 1
    Private Const DNAMatch = 0
    Private Const DNANoMatch = 1

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents DNAStateYes As System.Windows.Forms.RadioButton
    Friend WithEvents DNAStateNo As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GuiltyProb As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DNAStateYes = New System.Windows.Forms.RadioButton
        Me.DNAStateNo = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.GuiltyProb = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'DNAStateYes
        '
        Me.DNAStateYes.Location = New System.Drawing.Point(24, 40)
        Me.DNAStateYes.Name = "DNAStateYes"
        Me.DNAStateYes.Size = New System.Drawing.Size(64, 16)
        Me.DNAStateYes.TabIndex = 0
        Me.DNAStateYes.Text = "Yes"
        '
        'DNAStateNo
        '
        Me.DNAStateNo.Location = New System.Drawing.Point(24, 64)
        Me.DNAStateNo.Name = "DNAStateNo"
        Me.DNAStateNo.Size = New System.Drawing.Size(64, 16)
        Me.DNAStateNo.TabIndex = 1
        Me.DNAStateNo.Text = "No"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(120, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Probability for guilty:"
        '
        'GuiltyProb
        '
        Me.GuiltyProb.Location = New System.Drawing.Point(120, 64)
        Me.GuiltyProb.Name = "GuiltyProb"
        Me.GuiltyProb.Size = New System.Drawing.Size(152, 23)
        Me.GuiltyProb.TabIndex = 3
        Me.GuiltyProb.Text = "0.00000000%"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "DNA-match:"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 117)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GuiltyProb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DNAStateNo)
        Me.Controls.Add(Me.DNAStateYes)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' A collection to hold the found parseErrors
        Dim hc As New HuginCollection
        Dim parseErrors As Object ' really a VB 6.0 Collection

        ' Create the Vb 6.0 Collection
        parseErrors = hc.toCollection()

        ' Load the domain from the murder.net file and compile it.
        d = glob.LoadDomainFromNet("C:\murder.net", parseErrors, 10)
        d.Compile()

        ' Initially the DNANoMatch state is selected - display the probability 
        Call DNAState_Click(DNANoMatch)
        Exit Sub

    End Sub

    Private Sub Form1_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        d.Delete()

    End Sub

    Sub DNAState_Click(ByVal index As Integer)
        Dim n As HAPI.Node
        ' Fetch the node with label "DNA-match?" and name "DNA" from the domain
        n = d.GetNodeByName("DNA")

        ' Instantiate the Node with state "index" as evidence and sum propagate it
        n.SelectState(index)
        Call d.Propagate(hEquilibriums.hEquilibriumSum, hEvidenceModes.hModeNormal)

        ' Fetch the "Murderer?" node and display the probability for MurderYes
        n = d.GetNodeByName("M")
        GuiltyProb.Text = Format(n.Belief(MurderYes) * 100, "##0.00000000") & "%"
    End Sub
    Private Sub DNAStateYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DNAStateYes.CheckedChanged
        If DNAStateYes.Checked Then
            DNAState_Click(0)
        End If
    End Sub

    Private Sub DNAStateNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DNAStateNo.CheckedChanged
        If DNAStateNo.Checked Then
            DNAState_Click(1)
        End If
    End Sub
End Class
