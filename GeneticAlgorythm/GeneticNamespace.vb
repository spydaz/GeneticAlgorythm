Namespace GeneticNamespace

    Public Structure Population
        Public CurrentPopulation As List(Of DNA)

        ''' <summary>
        ''' Create an initial random popluation based on phrase inputted
        ''' </summary>
        ''' <param name="Phrase">initial string </param>
        ''' <param name="InitialPopulation">number of population dna cells</param>
        ''' <returns></returns>
        Public Shared Function GeneratePopulation(ByRef Phrase As String, ByRef InitialPopulation As Integer) As Population
            'Generate Start Population
            Dim StartPop As New Population
            StartPop.CurrentPopulation = New List(Of DNA)
            For i = 1 To InitialPopulation + 1
                StartPop.CurrentPopulation.Add(DNA.GenerateDNA(Phrase.Length))
            Next
            Return StartPop
        End Function
        Public Shared Function CrossOverPopulation(ByRef mPool As Population) As Population
            CrossOverPopulation = New Population
            CrossOverPopulation.CurrentPopulation = New List(Of DNA)
            Dim ParentA As New DNA
            ParentA.TextElement = New List(Of String)
            Dim ParentB As New DNA
            ParentB.TextElement = New List(Of String)
            Dim r As New Random()


            For Each item In mPool.CurrentPopulation
                'Randomize indexes
                Randomize()
                Dim Picka As Integer = r.Next(mPool.CurrentPopulation.Count - 1)
                Dim Pickb As Integer = r.Next(mPool.CurrentPopulation.Count - 1)
                'create parents
                ParentA = mPool.CurrentPopulation(Picka)
                ParentA = mPool.CurrentPopulation(Pickb)
                CrossOverPopulation.CurrentPopulation.Add(DNA.CrossoverDNA(ParentA, ParentB))
            Next


        End Function
        Public Shared Function MutatePopulation(ByRef mPool As Population, ByRef mutationRate As Integer) As Population
            MutatePopulation = New Population
            MutatePopulation.CurrentPopulation = New List(Of DNA)
            For Each item In mPool.CurrentPopulation
                MutatePopulation.CurrentPopulation.Add(DNA.MutateDNA(item, mutationRate))
            Next
        End Function
        Public Shared Function ReproducePopulation(ByRef MutationPool As Population, ByRef CrossoverPool As Population) As Population
            Dim ReproductionPool As New Population
            ReproductionPool.CurrentPopulation = New List(Of DNA)
            For Each item In MutationPool.CurrentPopulation
                ReproductionPool.CurrentPopulation.Add(item)
            Next
            For Each item In CrossoverPool.CurrentPopulation
                ReproductionPool.CurrentPopulation.Add(item)
            Next
            Return ReproductionPool
        End Function

        Public Shared Function SelectPopulation(ByRef NaturalSelectionPool As Population) As Population
            Dim SelectionPopulation As New Population
            SelectionPopulation.CurrentPopulation = New List(Of DNA)
            For Each item In NaturalSelectionPool.CurrentPopulation
                If item.Fitness > 0 Then
                    SelectionPopulation.CurrentPopulation.Add(item)
                Else
                End If
            Next
            Return SelectionPopulation
        End Function
    End Structure
    Public Structure DNA
        Public TextElement As List(Of String)
        Public Function TextElementToString() As String
            Dim str As String = ""

            For Each item In Me.TextElement
                str = str + item
            Next
            Return str
        End Function
        Public Overrides Function ToString() As String
            Dim str As String = ""
            str = str & "Text :" & TextElementToString()
            str = str & "Fitness :" & Fitness.ToString
        End Function
        Public Function FitnessToString() As String
            Dim str As String = ""


            str = Fitness.ToString

            Return str
        End Function
        Public Fitness As Integer
        Public Shared Function GenerateDNA(ByRef leng As Integer) As DNA
            Dim NewDNA As New DNA
            Dim LastGen As Integer = 0
            NewDNA.TextElement = New List(Of String)

            For i = 1 To leng - 1
                LastGen = GenerateRndNumber()
                NewDNA.TextElement.Add(Chr(LastGen))
            Next
            NewDNA.Fitness = 0
            Return NewDNA
        End Function
        Public Shared Function GenerateChar(ByRef num As Integer) As Char

            GenerateChar = Chr(num)
        End Function
        Public Shared Function CalculateFitness(ByRef Target As DNA, ByRef TestCell As DNA) As Integer
            CalculateFitness = 0
            Dim score As Integer = 0
            For i = 0 To Target.FitnessToString.Length
                If Target.TextElement(i) = TestCell.TextElement(i) = True Then
                    score = score + 1
                End If

            Next

            Return score

        End Function
        Private Shared Function GenerateRndNumber() As Integer
            'Using the Default Constructor
            Randomize()

            Dim MyValue As Integer
            MyValue = Int(Rnd() * 9)
            MyValue = Int((126 * Rnd()) + 32)
            Return MyValue
        End Function
        ''' <summary>
        ''' Mutates the DNA(STRING) by the rate of mutation 
        ''' Here the rate is a plied as a single char
        ''' </summary>
        ''' <param name="OldDNA"></param>
        ''' <param name="MutationRate"></param>
        ''' <returns></returns>
        Public Shared Function MutateDNA(ByRef OldDNA As DNA, ByRef MutationRate As Integer) As DNA
            Randomize()
            Dim R As New Random()

            Dim Pick As Integer = R.Next(0, OldDNA.tostring.Length - 1)
            For i = 1 To MutationRate
                OldDNA.TextElement(Pick) = DNA.GenerateChar(DNA.GenerateRndNumber())
                Pick = R.Next(0, OldDNA.tostring.Length - 1)
            Next
            Return OldDNA
        End Function
        ''' <summary>
        ''' Crossover Function Uses two parent DNA to create a new DNA Child
        ''' by crossing over have of each string
        ''' </summary>
        ''' <param name="Xchrome">Parent X</param>
        ''' <param name="Ychrome">Parent Y</param>
        ''' <returns></returns>
        Public Shared Function CrossoverDNA(ByRef Xchrome As DNA, ByRef Ychrome As DNA) As DNA
            Dim Child As New DNA

            Return Child
        End Function
        ''' <summary>
        ''' creates a version of the Phrase as a dna object
        ''' </summary>
        ''' <param name="phrase">string to convert</param>
        ''' <returns></returns>
        Public Shared Function CreateTargetDNA(ByRef phrase As String) As DNA
            Dim NewDNA As New DNA
            ' Create an array containing "A", "B", and "C".
            If phrase <> "" Then

                NewDNA.TextElement = New List(Of String)
                Dim charArray() As Char = phrase.ToCharArray
                Try

                    For Each item In charArray
                        NewDNA.TextElement.Add(item.ToString)
                    Next

                Catch ex As Exception

                End Try
                NewDNA.Fitness = phrase.Length
            End If
            Return NewDNA
        End Function


    End Structure
    ''' <summary>
    ''' Used to generate a new population
    ''' </summary>
    Public Class GeneticAlgoRhythm

        Public Sub New(ByRef Phrase As String, ByRef InitialPopulation As Integer, ByRef MutationRate As Integer)


        End Sub



#Region "Natural Selection"
        'Calc Fitness 
        'For each DNA > FITNESS CUT OFF
        'ADD TO NEW POOL
        Private NaturalSelectionPool As New Population
#End Region

#Region "Crossover"




#End Region

#Region "Mutate"


#End Region

#Region "Reproduce "
        Private ReproductionPool As New Population




#End Region
    End Class






End Namespace
