VERSION 5.00
Begin VB.Form Murder 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "The Murder Trial"
   ClientHeight    =   720
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   5115
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   720
   ScaleWidth      =   5115
   StartUpPosition =   3  'Windows Default
   Begin VB.OptionButton DNAState 
      Caption         =   "yes"
      Height          =   255
      Index           =   0
      Left            =   1200
      TabIndex        =   4
      Top             =   120
      Width           =   615
   End
   Begin VB.OptionButton DNAState 
      Caption         =   "no"
      Height          =   255
      Index           =   1
      Left            =   1200
      TabIndex        =   3
      Top             =   360
      Value           =   -1  'True
      Width           =   615
   End
   Begin VB.Label GuiltyProb 
      Caption         =   "0.00000000%"
      Height          =   255
      Left            =   3720
      TabIndex        =   2
      Top             =   120
      Width           =   1335
   End
   Begin VB.Label Label2 
      Caption         =   "Probability for guilty:"
      Height          =   255
      Left            =   2160
      TabIndex        =   1
      Top             =   120
      Width           =   1815
   End
   Begin VB.Label Label1 
      Caption         =   "DNA-match:"
      Height          =   255
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   975
   End
End
Attribute VB_Name = "Murder"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim d As HAPI.Domain
Private Const MurderYes = 0
Private Const MurderNo = 1
Private Const DNAMatch = 0
Private Const DNANoMatch = 1


Private Sub Form_Load()
    ' A collection to hold the found parseErrors
    Dim parseErrors As Collection

    ' Load the domain from the murder.net file and compile it.
    Set d = HAPI.LoadDomainFromNet("c:\murder.net", parseErrors, 10)
    d.Compile
    
    ' Initially the DNANoMatch state is selected - display the probability
    Call DNAState_Click(DNANoMatch)
    Exit Sub
End Sub

Private Sub Form_Terminate()
    ' We are done using the domain - explicitly delete it.
    d.Delete
End Sub


Private Sub DNAState_Click(Index As Integer)
    Dim n As HAPI.Node
    
    ' Fetch the node with label "DNA-match?" and name "DNA" from the domain
    Set n = d.GetNodeByName("DNA")
    
    ' Instantiate the Node with state Index as evidence and sum propagate
    n.SelectState (Index)
    Call d.Propagate(HAPI.hEquilibriumSum, HAPI.hModeNormal)
    
    ' Fetch "Murderer?" node and display the probability for MurderYes
    Set n = d.GetNodeByName("M")
    GuiltyProb.Caption = Format(n.Belief(MurderYes) * 100, "##0.00000000") & "%"
End Sub

