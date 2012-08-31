using System;
using System.Linq;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Phone.Controls;

namespace HelloPhone
{
    public partial class Video : PhoneApplicationPage
    {
        public Video()
        {
            InitializeComponent();
            MediaElementTest.Play();
        }

        private void MediaElementTest_Tap(object sender, GestureEventArgs e)
        {
            if (MediaElementTest.CurrentState == MediaElementState.Playing)
            {
                MediaElementTest.Pause();
            }
            else
            {
                MediaElementTest.Play();
            }
        }
    }
}