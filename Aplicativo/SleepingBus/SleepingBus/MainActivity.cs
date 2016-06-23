using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace SleepingBus
{
    [Activity(Label = "SleepingBus", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
            //Button button = FindViewById<Button>(Resource.Id.MyButton);

            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };


            Button button = FindViewById<Button>(Resource.Id.MyButton);

            // Método que pega o clique do botão
            button.Click += delegate
            {
                // Ao clicar o botão ele pega o valor que conta em txtValorx1 e joga na variavel valorx1, txtValorx2 e joga na variavel valorx2 e txtValory1 e joga na variavel valory1
                var valorx1 = FindViewById<EditText>(Resource.Id.txtValorx1);
                var valorx2 = FindViewById<EditText>(Resource.Id.txtValorx2);
                var valory1 = FindViewById<EditText>(Resource.Id.txtValory1);
                var valory2 = FindViewById<EditText>(Resource.Id.txtValory2);

                // Na variavel ladoa calcula valorx1 * valory2(que neste caso é o que estamos buscando por isso não entra na conta)

                var ladoa = Convert.ToInt32(valorx1.Text);

                // Na variavel ladob calcula valorx2 * valory1
                var ladob = Convert.ToInt32(valorx2.Text) * Convert.ToInt32(valory1.Text);

                // Realiza o calculo final colocando dividindo a variavel ladob pela ladoa
                var resultado = ladob / ladoa;


                // Mostra o Resultado final no campo valory2
                valory2.Text = resultado.ToString();
            };
        }
    }
}

