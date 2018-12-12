using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace samplecode.AirbnbLottie
{
    public class LottieAnimationViewModel : BaseViewModel
    {
        private string animationName;
        public string AnimationName
        {
            get => animationName;
            set => SetProperty(ref animationName, value);
        }

        private string animationPlayed;
        public string AnimationPlayed
        {
            get => animationPlayed;
            set => SetProperty(ref animationPlayed, value);
        }

        private int currentAnimation { get; set; }
        private int played { get; set; }
        private List<string> animationList { get; set; } 

        public ICommand PlayingCommand { get; set; }
        public ICommand FinishedCommand { get; set; }
        public ICommand ClickedCommand { get; set; }

        public LottieAnimationViewModel()
        {
            currentAnimation = 0;
            played = 0;
            animationList = new List<string>() 
            {
                "check_animation.json", "idea_bulb.json", "washing_machine.json"
            };
            AnimationName = animationList[currentAnimation];
            AnimationPlayed = SetAnimationPlayed(played);

            MessagingCenter.Send(this, "play");

            PlayingCommand = new Command(Playing);
            FinishedCommand = new Command(Finished);
            ClickedCommand = new Command(Clicked);
        }

        private void Playing()
        {
            AnimationName = animationList[currentAnimation];
        }

        private void Finished()
        {
            played++;
            AnimationPlayed = SetAnimationPlayed(played);
            MessagingCenter.Send(this, "play");
        }

        private void Clicked()
        {
            if (currentAnimation < 2)
                currentAnimation++;
            else
                currentAnimation = 0;

            played = 0;
            AnimationPlayed = SetAnimationPlayed(played);
            MessagingCenter.Send(this, "play");
        }

        private string SetAnimationPlayed(int number)
        {
            return $"Animation Played {number} times";
        }
    }
}
