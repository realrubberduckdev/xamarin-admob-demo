namespace SimpleJigsaw
{
    public class SimpleJigsawConstants
    {
#if DEBUG

        // test add unit id from https://developers.google.com/admob/android/test-ads
        public const string adMobBannerUnitId = "ca-app-pub-3940256099942544/6300978111";

#else
        public const string adMobBannerUnitId = "ca-app-pub-5606109468591192/6674835395";
#endif
        public const string adMobAppId = "ca-app-pub-5606109468591192~7021168375";
    }
}