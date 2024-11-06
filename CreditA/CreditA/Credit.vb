Namespace CreditCeleste
    Public Class Credit
        '' Pourquoi une classe crédit 
        '
        ' Réutilisable partout; y compris en aspx
        'variable privée

        Private monMontant As Double
        Private monDurée As Double
        Private monTaux As Double
        Private monMensualite As Double

        'le constructeur
        '
        ' en c# --> credit 
        Sub New() ''constructeur


        End Sub
        Sub New(montant As Double, duree As Double, taux As Double) ''constructeur
            'par défaut, il est public
            'en c#, il est privé
            monMontant = montant
            monDurée = duree
            monTaux = taux

            ' ici c'est la mensualité qui sera calculée
            monMensualite = 0

        End Sub
        Sub New(montant As Double, duree As Double, taux As Double, mensualite As Double) ''constructeur
            'par défaut, il est public
            'en c#, il est privé
            monMontant = montant
            monDurée = duree
            monTaux = taux
            monMensualite = mensualite

            ' ici c'est la valeur à 0 qui sera calculé 
            ' par itération successive 

        End Sub
        Public Function getMensualite()
            '
            '
            ' m =V0*i(1-(1+i)^-n)
            'm: mensualité; V0: montant financé initial; n : durée en mois ;
            'i taux annuel
            Dim tauxMens As Double = monTaux / 1200 'sur 12 mois mais en pourcentage 

            monMensualite = Math.Round((monMontant * tauxMens) / (1 - Math.Pow(1 + tauxMens, -monDurée)), 2)

            Return monMensualite
        End Function
        Public Function getCredit()
            Return monMontant + " " + monDurée + " " + monMensualite + " " + monTaux
        End Function

    End Class

End Namespace
