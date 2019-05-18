using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using JetBrains.Annotations;

public class LoadBeerObjcts : MonoBehaviour
{
    #if UNITY_EDITOR

    [UnityEditor.MenuItem("Beer/Load beer items")]
    public static void ImportBeerTypes()
    {
        for (int i = 1; i < 20; i++)
        {
            string assetPath = "Assets/Json/Parsed/Beer" + i + ".asset";
            string jsonPath = "Assets/Json/beer" + i + ".json";
            StreamReader reader = new StreamReader(jsonPath);
            string json = reader.ReadToEnd();
            reader.Close();

            print(json);

            BeerInfo beerInfo = UnityEditor.AssetDatabase.LoadAssetAtPath<BeerInfo>(assetPath);
            if (beerInfo == null)
            {
                beerInfo = ScriptableObject.CreateInstance<BeerInfo>();
                UnityEditor.AssetDatabase.CreateAsset(beerInfo, assetPath);
                UnityEditor.AssetDatabase.SaveAssets();
            }
            
            JsonUtility.FromJsonOverwrite(json,beerInfo);

            print(beerInfo.title);
            
            beerInfo.SetDirty();
            UnityEditor.AssetDatabase.SaveAssets();
        }
    }
    #endif
}
