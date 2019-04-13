Imports GeneticAlgorythm.GeneticNamespace

Public Class FormGeneticLearner


    ''' <summary>
    ''' The phrase Converted to a DNA object
    ''' </summary>
    Public TargetDNA As New DNA
    Public TargetPhrase As String = ""
    Public InitialPopulation As Integer = 0
    Public MutationRate As Double = 0.1
    Public LearningPhrase As String = ""

    Private Sub ButtonExecute_Click(sender As Object, e As EventArgs) Handles ButtonExecute.Click

        Dim StartPopulation As New Population

        LearningPhrase = TextBoxPhrase.Text
        InitialPopulation = NumericPopulation.Value
        MutationRate = NumericMutationRate.Value
        'Generate
        TargetDNA = DNA.CreateTargetDNA(LearningPhrase)

        StartPopulation = Population.GeneratePopulation(LearningPhrase, InitialPopulation)
        TargetPhrase = LearningPhrase

        UpdateStat("TARGET PHRASE: " & TargetDNA.ToString)
        UpdateStat("Initial Population :" & InitialPopulation.ToString)
        UpdateStat("Mutation Rate :" & MutationRate.ToString)
        UpdateStat("----------------------------------------------------")
        UpdateStat("START POPULATION")
        UpdateStat("----------------------------------------------------")
        Dim count As Integer = 1
        For Each item As DNA In StartPopulation.CurrentPopulation

            UpdateStat(count & ") " & "[" & item.FitnessToString & ": " & item.TextElementToString & "]")
            count += 1
        Next

        Dim NewPop As Population = NaturalSelectionProcess(StartPopulation)
        UpdateOutput("TARGET PHRASE: " & TargetDNA.ToString)
        UpdateOutput("Initial Population :" & InitialPopulation.ToString)
        UpdateOutput("Mutation Rate :" & MutationRate.ToString)
        UpdateOutput("----------------------------------------------------")
        For Each item In NewPop.CurrentPopulation
            UpdateOutput("[" & item.TextElementToString & "]")
        Next

    End Sub

    Public Function NaturalSelectionProcess(ByRef StartPopulation As Population) As Population

        StartPopulation = CalcFitness(StartPopulation)
        StartPopulation = SelectPopulation(StartPopulation)
        Dim CrossoverPop As Population = CrossOverPopulation(StartPopulation)
        Dim MutationPop As Population = MutatePopulation(StartPopulation)
        Dim NewPopulation As Population = ReproducePopulation(MutationPop, CrossoverPop)

        Return NewPopulation
    End Function

    Public Function ReproducePopulation(ByRef MutationPop As Population, ByRef CrossoverPop As Population) As Population
        UpdateStat("----------------------------------------------------")
        UpdateStat("Reproduce POPULATION")
        UpdateStat("----------------------------------------------------")
        Dim NewPop As Population = Population.ReproducePopulation(MutationPop, CrossoverPop)
        For Each item In NewPop.CurrentPopulation
            UpdateStat("FITNESS: " & "[" & item.FitnessToString & ": " & item.TextElementToString & "]")
        Next
        Return NewPop
    End Function

    Public Function MutatePopulation(ByRef StartPopulation As Population) As Population
        UpdateStat("----------------------------------------------------")
        UpdateStat("Mutate POPULATION")
        UpdateStat("----------------------------------------------------")
        StartPopulation = Population.MutatePopulation(StartPopulation, MutationRate)
        For Each item In StartPopulation.CurrentPopulation
            UpdateStat("FITNESS: " & "[" & item.FitnessToString & ": " & item.TextElementToString & "]")
        Next
        Return StartPopulation
    End Function
    Public Function CrossOverPopulation(ByRef StartPopulation As Population) As Population
        UpdateStat("----------------------------------------------------")
        UpdateStat("Crossover POPULATION")
        UpdateStat("----------------------------------------------------")
        StartPopulation = Population.CrossOverPopulation(StartPopulation)
        For Each item In StartPopulation.CurrentPopulation
            UpdateStat("FITNESS: " & "[" & item.FitnessToString & ": " & item.TextElementToString & "]")
        Next
        Return StartPopulation
    End Function
    Public Function SelectPopulation(ByRef StartPopulation As Population) As Population
        UpdateStat("----------------------------------------------------")
        UpdateStat("Select POPULATION")
        UpdateStat("----------------------------------------------------")
        StartPopulation = Population.SelectPopulation(StartPopulation)
        For Each item In StartPopulation.CurrentPopulation
            UpdateStat("FITNESS: " & "[" & item.FitnessToString & ": " & item.TextElementToString & "]")
        Next
        Return StartPopulation
    End Function
    Public Function CalcFitness(ByRef StartPop As Population) As Population
        UpdateStat("----------------------------------------------------")
        UpdateStat("Calculate Fitness")
        UpdateStat("----------------------------------------------------")
        For Each item In StartPop.CurrentPopulation
            item.Fitness = DNA.CalculateFitness(TargetDNA, item)
            UpdateStat("FITNESS: " & "[" & item.FitnessToString & ": " & item.TextElementToString & "]")
        Next
        Return StartPop
    End Function

    Public Sub UpdateOutput(ByRef Txt As String)
        TextBoxOutput.Text &= vbNewLine & Txt
    End Sub
    Public Sub UpdateStat(ByRef Txt As String)
        TextBoxDisplayStats.Text &= vbNewLine & Txt
    End Sub

    Private Sub TextBoxPhrase_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPhrase.TextChanged
        NumericMutationRate.Maximum = TextBoxPhrase.TextLength
    End Sub


End Class
