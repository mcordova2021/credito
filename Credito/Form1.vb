Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim netsum As Double
        Dim inarray(6) As Integer
        Dim outarray(7) As Integer
        Static feature2(9) As Double

        ' inarray(1) is EA
        ' inarray(2) is PN
        ' inarray(3) is PJ
        ' inarray(4) is D
        ' inarray(5) is I
        ' inarray(6) is DE
        ' outarray(1) is EL
        ' outarray(2) is EA
        ' outarray(3) is CP
        ' outarray(4) is CC
        ' outarray(5) is CC
        ' outarray(6) is CVV
        ' outarray(7) is CVTP

        inarray(1) = Val(Me.TextBox1.Text)
        inarray(2) = Val(Me.TextBox2.Text)
        inarray(3) = Val(Me.TextBox3.Text)
        inarray(4) = Val(Me.TextBox4.Text)
        inarray(5) = Val(Me.TextBox5.Text)
        inarray(6) = Val(Me.TextBox6.Text)

        If (inarray(1) < 0) Then inarray(1) = 0
        If (inarray(1) > 1) Then inarray(1) = 1
        inarray(1) = inarray(1)

        If (inarray(2) < 1) Then inarray(2) = 1
        If (inarray(2) > 2) Then inarray(2) = 2
        inarray(2) = (inarray(2) - 1)

        If (inarray(3) < 0) Then inarray(3) = 0
        If (inarray(3) > 1) Then inarray(3) = 1
        inarray(3) = inarray(3)

        If (inarray(4) < 0) Then inarray(4) = 0
        If (inarray(4) > 1) Then inarray(4) = 1
        inarray(4) = inarray(4)

        If (inarray(5) < 0) Then inarray(5) = 0
        If (inarray(5) > 1) Then inarray(5) = 1
        inarray(5) = inarray(5)

        If (inarray(6) < 0) Then inarray(6) = 0
        If (inarray(6) > 1) Then inarray(6) = 1
        inarray(6) = inarray(6)

        netsum = 0.552925
        netsum = netsum + inarray(1) * 2.624773
        netsum = netsum + inarray(2) * -0.2116123
        netsum = netsum + inarray(3) * 0.3384093
        netsum = netsum + inarray(4) * 0.654878
        netsum = netsum + inarray(5) * -2.384259
        netsum = netsum + inarray(6) * 1.012083
        feature2(1) = 1 / (1 + Math.Exp(-netsum))

        netsum = 0.2864033
        netsum = netsum + inarray(1) * -0.232227
        netsum = netsum + inarray(2) * -0.2004608
        netsum = netsum + inarray(3) * 0.3380726
        netsum = netsum + inarray(4) * 0.3092833
        netsum = netsum + inarray(5) * -1.9234
        netsum = netsum + inarray(6) * -1.255504
        feature2(2) = 1 / (1 + Math.Exp(-netsum))

        netsum = -0.3202231
        netsum = netsum + inarray(1) * 1.077787
        netsum = netsum + inarray(2) * 0.293115
        netsum = netsum + inarray(3) * 2.355233
        netsum = netsum + inarray(4) * -1.844521
        netsum = netsum + inarray(5) * -1.843686
        netsum = netsum + inarray(6) * -0.5675715
        feature2(3) = 1 / (1 + Math.Exp(-netsum))

        netsum = -0.6125705
        netsum = netsum + inarray(1) * 4.149592
        netsum = netsum + inarray(2) * -0.03258462
        netsum = netsum + inarray(3) * -1.024187
        netsum = netsum + inarray(4) * -1.040119
        netsum = netsum + inarray(5) * -1.032503
        netsum = netsum + inarray(6) * 0.4039429
        feature2(4) = 1 / (1 + Math.Exp(-netsum))

        netsum = 0.9853073
        netsum = netsum + inarray(1) * -1.723817
        netsum = netsum + inarray(2) * -0.2285501
        netsum = netsum + inarray(3) * -1.625859
        netsum = netsum + inarray(4) * 1.237068
        netsum = netsum + inarray(5) * -3.020462
        netsum = netsum + inarray(6) * 0.9360621
        feature2(5) = 1 / (1 + Math.Exp(-netsum))

        netsum = 0.4483171
        netsum = netsum + inarray(1) * 0.135884
        netsum = netsum + inarray(2) * -0.2971984
        netsum = netsum + inarray(3) * -1.750201
        netsum = netsum + inarray(4) * 1.014766
        netsum = netsum + inarray(5) * 0.1713855
        netsum = netsum + inarray(6) * -4.692516
        feature2(6) = 1 / (1 + Math.Exp(-netsum))

        netsum = -1.815358
        netsum = netsum + inarray(1) * -1.660086
        netsum = netsum + inarray(2) * -0.2946532
        netsum = netsum + inarray(3) * 3.666048
        netsum = netsum + inarray(4) * -0.1632731
        netsum = netsum + inarray(5) * 0.05557675
        netsum = netsum + inarray(6) * -2.592651
        feature2(7) = 1 / (1 + Math.Exp(-netsum))

        netsum = -1.468176
        netsum = netsum + inarray(1) * -0.8806654
        netsum = netsum + inarray(2) * -0.07327189
        netsum = netsum + inarray(3) * -2.381941
        netsum = netsum + inarray(4) * -0.7902038
        netsum = netsum + inarray(5) * 3.295805
        netsum = netsum + inarray(6) * -3.010131
        feature2(8) = 1 / (1 + Math.Exp(-netsum))

        netsum = 0.134371
        netsum = netsum + inarray(1) * -1.801088
        netsum = netsum + inarray(2) * 0.01899777
        netsum = netsum + inarray(3) * 0.515391
        netsum = netsum + inarray(4) * -2.266897
        netsum = netsum + inarray(5) * -1.211797
        netsum = netsum + inarray(6) * 3.070935
        feature2(9) = 1 / (1 + Math.Exp(-netsum))

        netsum = -2.688084
        netsum = netsum + feature2(1) * -0.1949707
        netsum = netsum + feature2(2) * 0.2036091
        netsum = netsum + feature2(3) * 3.372597
        netsum = netsum + feature2(4) * 0.4929688
        netsum = netsum + feature2(5) * -0.6245344
        netsum = netsum + feature2(6) * 0.6217883
        netsum = netsum + feature2(7) * -0.4985358
        netsum = netsum + feature2(8) * 0.1053541
        netsum = netsum + feature2(9) * 1.815413
        outarray(1) = 1 / (1 + Math.Exp(-netsum))

        netsum = -0.7274325
        netsum = netsum + feature2(1) * 1.398895
        netsum = netsum + feature2(2) * -1.034414
        netsum = netsum + feature2(3) * -2.475591
        netsum = netsum + feature2(4) * 2.815179
        netsum = netsum + feature2(5) * -1.587131
        netsum = netsum + feature2(6) * -0.1551941
        netsum = netsum + feature2(7) * -0.7814186
        netsum = netsum + feature2(8) * -1.214203
        netsum = netsum + feature2(9) * -2.923214
        outarray(2) = 1 / (1 + Math.Exp(-netsum))

        netsum = 1.63765
        netsum = netsum + feature2(1) * -1.489454
        netsum = netsum + feature2(2) * -0.7080432
        netsum = netsum + feature2(3) * -1.551334
        netsum = netsum + feature2(4) * -3.096043
        netsum = netsum + feature2(5) * 1.53787
        netsum = netsum + feature2(6) * -3.665871
        netsum = netsum + feature2(7) * -1.510865
        netsum = netsum + feature2(8) * -0.552496
        netsum = netsum + feature2(9) * 2.365625
        outarray(3) = 1 / (1 + Math.Exp(-netsum))

        netsum = -3.172832
        netsum = netsum + feature2(1) * 0.8154854
        netsum = netsum + feature2(2) * 2.057259
        netsum = netsum + feature2(3) * 0.6460317
        netsum = netsum + feature2(4) * -0.1476683
        netsum = netsum + feature2(5) * 2.572043
        netsum = netsum + feature2(6) * 1.870373
        netsum = netsum + feature2(7) * -0.4693826
        netsum = netsum + feature2(8) * -2.573551
        netsum = netsum + feature2(9) * -1.562899
        outarray(4) = 1 / (1 + Math.Exp(-netsum))

        netsum = -0.4524418
        netsum = netsum + feature2(1) * -0.1259253
        netsum = netsum + feature2(2) * 0.3251145
        netsum = netsum + feature2(3) * 1.024084
        netsum = netsum + feature2(4) * -1.331062
        netsum = netsum + feature2(5) * -1.316061
        netsum = netsum + feature2(6) * -0.9064624
        netsum = netsum + feature2(7) * 3.965195
        netsum = netsum + feature2(8) * -1.350906
        netsum = netsum + feature2(9) * -1.691364
        outarray(5) = 1 / (1 + Math.Exp(-netsum))

        netsum = -0.2219889
        netsum = netsum + feature2(1) * -1.54205
        netsum = netsum + feature2(2) * -0.1211412
        netsum = netsum + feature2(3) * 1.083872
        netsum = netsum + feature2(4) * -0.3466245
        netsum = netsum + feature2(5) * -2.439729
        netsum = netsum + feature2(6) * 1.207266
        netsum = netsum + feature2(7) * 2.094129
        netsum = netsum + feature2(8) * 3.144963
        netsum = netsum + feature2(9) * -0.9136803
        outarray(6) = 1 / (1 + Math.Exp(-netsum))

        netsum = -1.538077
        netsum = netsum + feature2(1) * -1.419736
        netsum = netsum + feature2(2) * -0.5824777
        netsum = netsum + feature2(3) * 0.2159221
        netsum = netsum + feature2(4) * 0.6310436
        netsum = netsum + feature2(5) * -1.677176
        netsum = netsum + feature2(6) * 2.518753
        netsum = netsum + feature2(7) * -2.358588
        netsum = netsum + feature2(8) * 3.842276
        netsum = netsum + feature2(9) * 0.7231038
        outarray(7) = 1 / (1 + Math.Exp(-netsum))


        outarray(1) = (outarray(1) - 0.1) / 0.8
        If (outarray(1) < 0) Then outarray(1) = 0
        If (outarray(1) > 1) Then outarray(1) = 1

        outarray(2) = (outarray(2) - 0.1) / 0.8
        If (outarray(2) < 0) Then outarray(2) = 0
        If (outarray(2) > 1) Then outarray(2) = 1

        outarray(3) = (outarray(3) - 0.1) / 0.8
        If (outarray(3) < 0) Then outarray(3) = 0
        If (outarray(3) > 1) Then outarray(3) = 1

        outarray(4) = (outarray(4) - 0.1) / 0.8
        If (outarray(4) < 0) Then outarray(4) = 0
        If (outarray(4) > 1) Then outarray(4) = 1

        outarray(5) = (outarray(5) - 0.1) / 0.8
        If (outarray(5) < 0) Then outarray(5) = 0
        If (outarray(5) > 1) Then outarray(5) = 1

        outarray(6) = (outarray(6) - 0.1) / 0.8
        If (outarray(6) < 0) Then outarray(6) = 0
        If (outarray(6) > 1) Then outarray(6) = 1

        outarray(7) = (outarray(7) - 0.1) / 0.8
        If (outarray(7) < 0) Then outarray(7) = 0
        If (outarray(7) > 1) Then outarray(7) = 1

        Me.TextBox7.Text = outarray(1)
        Me.TextBox8.Text = outarray(2)
        Me.TextBox9.Text = outarray(3)
        Me.TextBox10.Text = outarray(4)
        Me.TextBox11.Text = outarray(5)
        Me.TextBox12.Text = outarray(6)
        Me.TextBox13.Text = outarray(7)

    End Sub
End Class
