using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace valorantProject.Models.Weapons
{
    public class Root2
    {
        public int status { get; set; }
        public List<Datum> data { get; set; }
    }
    public class AdsStats
    {
        public double zoomMultiplier { get; set; }
        public double fireRate { get; set; }
        public double runSpeedMultiplier { get; set; }
        public int burstCount { get; set; }
        public double firstBulletAccuracy { get; set; }
    }

    public class AirBurstStats
    {
        public int shotgunPelletCount { get; set; }
        public double burstDistance { get; set; }
    }

    public class AltShotgunStats
    {
        public int shotgunPelletCount { get; set; }
        public double burstRate { get; set; }
    }

    public class Chroma
    {
        public string uuid { get; set; }
        public string displayName { get; set; }
        public string displayIcon { get; set; }
        public string fullRender { get; set; }
        public string swatch { get; set; }
        public string streamedVideo { get; set; }
        public string assetPath { get; set; }
    }

    public class DamageRange
    {
        public int rangeStartMeters { get; set; }
        public int rangeEndMeters { get; set; }
        public double headDamage { get; set; }
        public int bodyDamage { get; set; }
        public double legDamage { get; set; }
    }

    public class Datum
    {
        public string uuid { get; set; }
        public string displayName { get; set; }
        public string category { get; set; }
        public string defaultSkinUuid { get; set; }
        public string displayIcon { get; set; }
        public string killStreamIcon { get; set; }
        public string assetPath { get; set; }
        public WeaponStats weaponStats { get; set; }
        public ShopData shopData { get; set; }
        public List<Skin> skins { get; set; }
    }

    public class GridPosition
    {
        public int row { get; set; }
        public int column { get; set; }
    }

    public class Level
    {
        public string uuid { get; set; }
        public string displayName { get; set; }
        public string levelItem { get; set; }
        public string displayIcon { get; set; }
        public string streamedVideo { get; set; }
        public string assetPath { get; set; }
    }

    

    public class ShopData
    {
        public int cost { get; set; }
        public string category { get; set; }
        public string categoryText { get; set; }
        public GridPosition gridPosition { get; set; }
        public bool canBeTrashed { get; set; }
        public object image { get; set; }
        public string newImage { get; set; }
        public object newImage2 { get; set; }
        public string assetPath { get; set; }
    }

    public class Skin
    {
        public string uuid { get; set; }
        public string displayName { get; set; }
        public string themeUuid { get; set; }
        public string contentTierUuid { get; set; }
        public string displayIcon { get; set; }
        public string wallpaper { get; set; }
        public string assetPath { get; set; }
        public List<Chroma> chromas { get; set; }
        public List<Level> levels { get; set; }
    }

    public class WeaponStats
    {
        public double fireRate { get; set; }
        public int magazineSize { get; set; }
        public double runSpeedMultiplier { get; set; }
        public double equipTimeSeconds { get; set; }
        public double reloadTimeSeconds { get; set; }
        public double firstBulletAccuracy { get; set; }
        public int shotgunPelletCount { get; set; }
        public string wallPenetration { get; set; }
        public string feature { get; set; }
        public string fireMode { get; set; }
        public string altFireType { get; set; }
        public AdsStats adsStats { get; set; }
        public AltShotgunStats altShotgunStats { get; set; }
        public AirBurstStats airBurstStats { get; set; }
        public List<DamageRange> damageRanges { get; set; }
    }


}