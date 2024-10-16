using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace TicTacToeEnWinforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {}

        static void SiguienteTurno(Button Celda) {
            if (CheckSiLaCeldaEstaVacia(Celda))
            {
                DibujarEnCelda(Celda);
                if (CheckSiHayGanador() != "") ProtocoloSiHayGanador(currentPlayer);
                if (CheckSiEsEmpate() && CheckSiHayGanador() == "") ProtocoloSiHayEmpate();
                CambiarJugador();
            }
        }

        static void ProtocoloSiHayGanador(string winner)
        {
            botonComenzarJuego.Text = "Resetear";
            botonComenzarJuego.Enabled = true;
            CambiarEnableDeLosBotones(false);
            MessageBox.Show("El ganador es " + winner);
        }

        static void ProtocoloSiHayEmpate()
        {
            botonComenzarJuego.Text = "Resetear";
            botonComenzarJuego.Enabled = true;
            CambiarEnableDeLosBotones(false);
            MessageBox.Show("Hubo un empate");
        }

        static void DibujarEnCelda(Button Celda) 
        {
            Celda.Text = currentPlayer;
        }

        static bool CheckSiEsEmpate()
        {
            foreach (var celda in botones)
            {
                if (CheckSiLaCeldaEstaVacia(celda)) return false;
            }
            return true;
        }

        static string CheckSiHayGanador()
        {
            if (VerificarGanadorEnLasCeldas(botones[0], botones[1], botones[2])) return botones[0].Text;
            if (VerificarGanadorEnLasCeldas(botones[3], botones[4], botones[5])) return botones[3].Text;
            if (VerificarGanadorEnLasCeldas(botones[6], botones[7], botones[8])) return botones[6].Text;

            if (VerificarGanadorEnLasCeldas(botones[0], botones[3], botones[6])) return botones[0].Text;
            if (VerificarGanadorEnLasCeldas(botones[1], botones[4], botones[7])) return botones[1].Text;
            if (VerificarGanadorEnLasCeldas(botones[2], botones[5], botones[8])) return botones[2].Text;

            if (VerificarGanadorEnLasCeldas(botones[0], botones[4], botones[8])) return botones[0].Text;
            if (VerificarGanadorEnLasCeldas(botones[2], botones[4], botones[6])) return botones[2].Text;
            return "";
        }
        static bool VerificarGanadorEnLasCeldas(Button Celda1, Button Celda2, Button Celda3)
        {
            return Celda1.Text == Celda2.Text && Celda2.Text == Celda3.Text && Celda3.Text != "";
        }

        static bool CheckSiLaCeldaEstaVacia(Button Celda)
        {
            return Celda.Text == "";
        }

        static void CambiarJugador() {
            /*Operacion ternaria*/

            /* Condicion ? valorSiEsVerdad : valorSiEsFalso */
            currentPlayer = currentPlayer == firstPlayer ? secondPlayer : firstPlayer;
        }

        static void CambiarEnableDeLosBotones(bool enabled)
        {
            foreach (var boton in botones)
            {
                boton.Enabled = enabled;
            }
        }

        static void VaciarCeldas() {
            foreach (var boton in botones)
            {
                boton.Text = "";
            }
        }

        const string firstPlayer = "o";
        const string secondPlayer = "x";
        private static string currentPlayer = firstPlayer;
        private static Button botonComenzarJuego;
        private static List<Button> botones = new List<Button>();

        /* Boton de comenzar juego */
        private void button1_Click(object sender, EventArgs e)
        {
            VaciarCeldas();
            botonComenzarJuego = ButtonComenzarJuego;
            botonComenzarJuego.Enabled = false;
            botonComenzarJuego.Text = "Juego en Proceso";

            if (!botones.Contains(ButtonCelda1))
            {
                botones.Add(ButtonCelda1);
                botones.Add(ButtonCelda2);
                botones.Add(ButtonCelda3);
                botones.Add(ButtonCelda4);
                botones.Add(ButtonCelda5);
                botones.Add(ButtonCelda6);
                botones.Add(ButtonCelda7);
                botones.Add(ButtonCelda8);
                botones.Add(ButtonCelda9);
            }

            CambiarEnableDeLosBotones(true);
            currentPlayer = firstPlayer;
        }

        private void ButtonCelda1_Click(object sender, EventArgs e) { SiguienteTurno(ButtonCelda1); }
        private void ButtonCelda2_Click(object sender, EventArgs e) { SiguienteTurno(ButtonCelda2); }
        private void ButtonCelda3_Click(object sender, EventArgs e) { SiguienteTurno(ButtonCelda3); }
        private void ButtonCelda4_Click(object sender, EventArgs e) { SiguienteTurno(ButtonCelda4); }
        private void ButtonCelda5_Click(object sender, EventArgs e) { SiguienteTurno(ButtonCelda5); }
        private void ButtonCelda6_Click(object sender, EventArgs e) { SiguienteTurno(ButtonCelda6); }
        private void ButtonCelda7_Click(object sender, EventArgs e) { SiguienteTurno(ButtonCelda7); }
        private void ButtonCelda8_Click(object sender, EventArgs e) { SiguienteTurno(ButtonCelda8); }
        private void ButtonCelda9_Click(object sender, EventArgs e) { SiguienteTurno(ButtonCelda9); }
    }
}
