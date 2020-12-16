#if !UNITY_IOS
// Copyright (C) 2015 Google, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using UnityEngine.Scripting;

namespace GoogleMobileAds {
    [Preserve]
    public class GoogleMobileAdsClientFactory : IClientFactory
    {
        public IBannerClient BuildBannerClient()
        {
            if (Application.platform == RuntimePlatform.Android)
            {
                return new GoogleMobileAds.Android.BannerClient();
            }
            return null;
        }

        public IInterstitialClient BuildInterstitialClient()
        {
            if (Application.platform == RuntimePlatform.Android)
            {
                return new GoogleMobileAds.Android.InterstitialClient();
            }
            return null;
        }

        public IRewardBasedVideoAdClient BuildRewardBasedVideoAdClient()
        {
            if (Application.platform == RuntimePlatform.Android)
            {
                return new GoogleMobileAds.Android.RewardBasedVideoAdClient();
            }
            return null;
        }

        public IRewardedAdClient BuildRewardedAdClient()
        {
            if (Application.platform == RuntimePlatform.Android)
            {
                return new GoogleMobileAds.Android.RewardedAdClient();
            }
            return null;
        }

        public IRewardedInterstitialAdClient BuildRewardedInterstitialAdClient()
        {
            if (Application.platform == RuntimePlatform.Android)
            {
                return new GoogleMobileAds.Android.RewardedInterstitialAdClient();
            }
            return null;
        }


        public IMobileAdsClient MobileAdsInstance()
        {
            if (Application.platform == RuntimePlatform.Android)
            {
                return GoogleMobileAds.Android.MobileAdsClient.Instance;
            }
            return null;
        }
    }
}
#endif
