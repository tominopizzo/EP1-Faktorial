Imports System


Imports System
    Imports System.Numerics
    Imports System.Security.Cryptography

    Module Program
        Sub Main(args As String())
            Dim cislo As Object
            Dim vysledek As Integer = 1

        Console.WriteLine("Zadej ��slo")
        cislo = Console.ReadLine


            If Not IsNumeric(cislo) Then
            Console.WriteLine(" Vstup mus� b�t ��slo ")
            Console.ReadKey()
                End
            End If
