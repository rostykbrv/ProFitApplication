
using ProFitApplication.Views;
using ProFitApplication.Views.Exercises;
using ProFitApplication.Views.KhathaYoga;
using ProFitApplication.Views.LowerBodyTraining;
using ProFitApplication.Views.PowerYoga;
using ProFitApplication.Views.UpperBodyTraining;
using ProFitApplication.Views.WeightTraining;

namespace ProFitApplication;

public partial class AppShell : Shell
{
	public AppShell()
	{

		InitializeComponent();
        Routing.RegisterRoute(nameof(SuccessWorkoutDone), typeof(SuccessWorkoutDone));
        Routing.RegisterRoute(nameof(LoginPage),typeof(LoginPage));
        Routing.RegisterRoute(nameof(StartPageView),typeof(StartPageView));
        Routing.RegisterRoute(nameof(ProfileView),typeof(ProfileView));
		Routing.RegisterRoute(nameof(HomeWorkoutPageView),typeof(HomeWorkoutPageView));
        Routing.RegisterRoute(nameof(YogaPageView), typeof(YogaPageView));
        Routing.RegisterRoute(nameof(GymWorkoutPage), typeof(GymWorkoutPage));
        Routing.RegisterRoute(nameof(DetailsExerciseGroupView), typeof(DetailsExerciseGroupView));

        Routing.RegisterRoute(nameof(JumpingJackPage), typeof(JumpingJackPage));
        Routing.RegisterRoute(nameof(HighKnees), typeof(HighKnees));
        Routing.RegisterRoute(nameof(RunningPlace), typeof(RunningPlace));
        Routing.RegisterRoute(nameof(Burpee), typeof(Burpee));

        Routing.RegisterRoute(nameof(Squat), typeof(Squat));
        Routing.RegisterRoute(nameof(Crunches), typeof(Crunches));
        Routing.RegisterRoute(nameof(Lunges), typeof(Lunges));
        Routing.RegisterRoute(nameof(Plank), typeof(Plank));
        Routing.RegisterRoute(nameof(PushUps), typeof(PushUps));

        Routing.RegisterRoute(nameof(ChairDips), typeof(ChairDips));
        Routing.RegisterRoute(nameof(DiamondPushUps), typeof(DiamondPushUps));
        Routing.RegisterRoute(nameof(PikePushUps), typeof(PikePushUps));
        Routing.RegisterRoute(nameof(PlankUpperBody), typeof(PlankUpperBody));
        Routing.RegisterRoute(nameof(PushUp), typeof(PushUp));
        Routing.RegisterRoute(nameof(Superman), typeof(Superman));

        Routing.RegisterRoute(nameof(BodyweightSquats), typeof(BodyweightSquats));
        Routing.RegisterRoute(nameof(GluteBridges), typeof(GluteBridges));
        Routing.RegisterRoute(nameof(Walking_Lunges), typeof(Walking_Lunges));
        Routing.RegisterRoute(nameof(WallSit), typeof(WallSit));

        Routing.RegisterRoute(nameof(LungesJump),typeof(LungesJump));
        Routing.RegisterRoute(nameof(SquatReach),typeof(SquatReach));
        Routing.RegisterRoute(nameof(DiamondAsan), typeof(DiamondAsan));
        Routing.RegisterRoute(nameof(MatsyasanaFishPose), typeof(MatsyasanaFishPose));
        Routing.RegisterRoute(nameof(Sukhasan),typeof(Sukhasan));
        Routing.RegisterRoute(nameof(SixPoints), typeof(SixPoints));
        Routing.RegisterRoute(nameof(Baby), typeof(Baby));
        Routing.RegisterRoute(nameof(Sumo), typeof(Sumo));
        Routing.RegisterRoute(nameof(Tree), typeof(Tree));
        Routing.RegisterRoute(nameof(Triangle), typeof(Triangle));
        Routing.RegisterRoute(nameof(Warrior), typeof(Warrior));
    }


}
