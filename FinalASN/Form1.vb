Public Class Form1

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        rbtnNone.Checked = True
        picSeafood.Visible = False
        picBeef.Visible = False
        picVeggie.Visible = False
        lblCalculator.Visible = True
        lblPrice.Text = ""
        txtPeople.Focus()
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCalculate.Click
        'declare variables
        Dim decMealCost As Decimal = 0
        Dim strFood As String = ""
        Dim strMealType As String
        Dim decSideCost As Decimal
        Dim decFinalCost As Decimal
        Dim strPeople As String
        Dim intPeople As Integer

        'call to food cost sub-procedure
        foodCost(decMealCost)

        'if statements that check the radio buttons and assign a side price
        If rbtnSide.Checked = True Then
            decSideCost = 1
            strMealType = "a side"
        ElseIf rbtnDrink.Checked = True Then
            decSideCost = 1.5
            strMealType = "a drink"
        ElseIf rbtnCombo.Checked = True Then
            decSideCost = 2.5
            strMealType = "a side and a drink"
        Else
            decSideCost = 0
            strMealType = "nothing else"
        End If

        'If statements that assign a food name to the string to be used when printing
        If decMealCost = 7 Then
            strFood = "Vegetarian"
        ElseIf decMealCost = 8 Then
            strFood = "Seafood"
        ElseIf decMealCost = 10 Then
            strFood = "Beef"
        Else
            'pops up a message box if decMealCost was not changed correctly in foodCost()
            MsgBox("Incorrect Value Assigned to Meal Cost, please try again", 5, "Value Error")
            txtPeople.Focus()

        End If

        'checks textbox for number of people, can not exceed number 5
        'try block catches if text is null (intPeople is null)
        Try
            strPeople = txtPeople.Text
            intPeople = Convert.ToInt32(strPeople)
        Catch Exception As FormatException
            MsgBox("No value detected, please try again", 5, "Error")
            lblPrice.Text = ""
            txtPeople.Focus()
        End Try
        If intPeople <= 5 Then
            'calculating final cost
            decFinalCost = intPeople * (decMealCost + decSideCost)
            'prints into label
            lblPrice.Text = "You will pay " & decFinalCost.ToString("C") & " for the " & strFood & " meal with " & strMealType & " for " & intPeople & " people."
        Else
            MsgBox("Number of people can not exceed 5, please try again", 5, "Input Error")
            lblPrice.Text = ""
            txtPeople.Clear()
            txtPeople.Focus()
        End If

    End Sub

    'sub procedure that assigns a value to food cost depending on which image is visible (which button was selected)
    Private Sub foodCost(ByRef decFoodCost As Decimal)
        If picSeafood.Visible = True Then
            decFoodCost = 8
        ElseIf picBeef.Visible = True Then
            decFoodCost = 10
        ElseIf picVeggie.Visible = True Then
            decFoodCost = 7
        Else
            MsgBox("Selection error has occured. Please try again", 5, "Null Picture Error")
        End If
    End Sub

    Private Sub btnVeg_Click(sender As Object, e As EventArgs) Handles btnVeg.Click
        lblCalculator.Visible = False
        picVeggie.Visible = True
        picSeafood.Visible = False
        picBeef.Visible = False
    End Sub

    Private Sub btnSeafood_Click(sender As Object, e As EventArgs) Handles btnSeafood.Click
        lblCalculator.Visible = False
        picBeef.Visible = False
        picSeafood.Visible = True
        picVeggie.Visible = False
    End Sub

    Private Sub btnBeef_Click(sender As Object, e As EventArgs) Handles btnBeef.Click
        lblCalculator.Visible = False
        picSeafood.Visible = False
        picVeggie.Visible = False
        picBeef.Visible = True
    End Sub
End Class
