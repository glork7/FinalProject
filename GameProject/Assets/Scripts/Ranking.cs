using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ranking : MonoBehaviour {

    public Text tRanking, l1Ranking, l2Ranking;
    public static int ttPuntuation, ppuntuation1, ppuntuation2;

    void Start()
    {
        ttPuntuation = PickingScript.tPuntuation;
        ppuntuation1 = PickingScript.puntuation1;
        ppuntuation2 = PickingScript.puntuation2;


        if (PickingScript.tutorial == true )
        {
            tRanking.text = ttPuntuation.ToString();
            if (ppuntuation1 != 100000)
            {
                l1Ranking.text = ppuntuation1.ToString();
            }
            if (ppuntuation2 != 100000)
            {
                l2Ranking.text = ppuntuation2.ToString();
            }
            PickingScript.level1 = false;
            PickingScript.level2 = false;

        }
        if (PickingScript.level1 == true)
        {
            tRanking.text = ttPuntuation.ToString();
            l1Ranking.text = ppuntuation1.ToString();
            if (ppuntuation2 != 100000)
            {
                l2Ranking.text = ppuntuation2.ToString();
            }
            PickingScript.tutorial = false;
            PickingScript.level2 = false;
        }
        if (PickingScript.level2 == true)
        {
            tRanking.text = ttPuntuation.ToString();
            l1Ranking.text = ppuntuation1.ToString();
            l2Ranking.text = ppuntuation2.ToString();

            PickingScript.tutorial = false;
            PickingScript.level1 = false;
        }
        if(BorrarPartida.deleteRanking == true)
        {
            tRanking.text = "";
            l1Ranking.text = "";
            l2Ranking.text = "";

            PickingScript.tutorial = false;
            PickingScript.level1 = false;
            PickingScript.level2 = false;
            BorrarPartida.deleteRanking = false;
        }
    }
}

        /*
        public Text tRanking1, tRanking2, tRanking3, tRanking4, tRanking5;
        public Text l1Ranking1, l1Ranking2, l1Ranking3, l1Ranking4, l1Ranking5;
        public Text l2Ranking1, l2Ranking2, l2Ranking3, l2Ranking4, l2Ranking5;

        private int tRankingg1, tRankingg2, tRankingg3, tRankingg4, tRankingg5;
        private int l1Rankingg1, l1Rankingg2, l1Rankingg3, l1Rankingg4, l1Rankingg5;
        private int l2Rankingg1, l2Rankingg2, l2Rankingg3, l2Rankingg4, l2Rankingg5;
        private int tPuntuation, puntuation1, puntuation2;
        private int counter;

        private string line;
        private string[] File;
        private string form;
        private string username;

        // Use this for initialization
        void Start() {

            //username = Login.gUsername + "Ranking";

            tPuntuation = PickingScript.tPuntuation;
            puntuation1 = PickingScript.puntuation1;
            puntuation2 = PickingScript.puntuation2;


            tRanking3.text = "0";
            tRanking4.text = "0";
            tRanking5.text = "0";

            l1Ranking1.text = "0";
            l1Ranking2.text = "0";
            l1Ranking3.text = "0";
            l1Ranking4.text = "0";
            l1Ranking5.text = "0";

            l2Ranking1.text = "0";
            l2Ranking2.text = "0";
            l2Ranking3.text = "0";
            l2Ranking4.text = "0";
            l2Ranking5.text = "0";

            int.TryParse(tRanking1.text, out tRankingg1);
            int.TryParse(tRanking2.text, out tRankingg2);
            int.TryParse(tRanking3.text, out tRankingg3);
            int.TryParse(tRanking4.text, out tRankingg4);
            int.TryParse(tRanking5.text, out tRankingg5);

            int.TryParse(l1Ranking1.text, out l1Rankingg1);
            int.TryParse(l1Ranking2.text, out l1Rankingg2);
            int.TryParse(l1Ranking3.text, out l1Rankingg3);
            int.TryParse(l1Ranking4.text, out l1Rankingg4);
            int.TryParse(l1Ranking5.text, out l1Rankingg5);

            int.TryParse(l2Ranking1.text, out l2Rankingg1);
            int.TryParse(l2Ranking2.text, out l2Rankingg2);
            int.TryParse(l2Ranking3.text, out l2Rankingg3);
            int.TryParse(l2Ranking4.text, out l2Rankingg4);
            int.TryParse(l2Ranking5.text, out l2Rankingg5);

            if(PickingScript.tutorial == true)
            {
                CallTRanking(tPuntuation);
            }
            else if(PickingScript.level2 == true)
            {
                CallL2Ranking(puntuation2);
            }
            else if (PickingScript.level1 == true)
            {
                CallL1Ranking(puntuation1);
            }

            form = (tRanking1.text + Environment.NewLine + tRanking2.text + Environment.NewLine + tRanking3.text + Environment.NewLine +
                tRanking4.text + Environment.NewLine + tRanking5.text + Environment.NewLine + l1Ranking1.text + Environment.NewLine + l1Ranking2.text +
                Environment.NewLine + l1Ranking3.text + Environment.NewLine + l1Ranking4.text + Environment.NewLine + l1Ranking5.text + 
                Environment.NewLine + l2Ranking1.text + Environment.NewLine + l2Ranking2.text +
                Environment.NewLine + l2Ranking3.text + Environment.NewLine + l2Ranking4.text + Environment.NewLine + l2Ranking5.text);

            SaveRanking(form, username);
            GetRanking(username);
        }

        // Update is called once per frame
        void Update () {

        }

        private void CallTRanking(int tPuntuation)
        {

            if (tRankingg1 < tPuntuation)
            {
                tRanking5.text = tRanking4.text;
                tRanking4.text = tRanking3.text;
                tRanking3.text = tRanking2.text;
                tRanking2.text = tRanking1.text;
                tRanking1.text = tPuntuation.ToString();

            }
            else if (tRankingg2 < tPuntuation)
            {
                tRanking5.text = tRanking4.text;
                tRanking4.text = tRanking3.text;
                tRanking3.text = tRanking2.text;
                tRanking2.text = tPuntuation.ToString();
            }
            else if (tRankingg3 < tPuntuation)
            {
                tRanking5.text = tRanking4.text;
                tRanking4.text = tRanking3.text;
                tRanking3.text = tPuntuation.ToString();
            }
            else if (tRankingg4 < tPuntuation)
            {
                tRanking5.text = tRanking4.text;
                tRanking4.text = tPuntuation.ToString();
            }
            else if (tRankingg5 < tPuntuation)
            {
                tRanking5.text = tPuntuation.ToString();
            }
        }

        private void CallL1Ranking(int puntuation1)
        {
            if(l1Rankingg1 < puntuation1)
            {
                l1Ranking5.text = l1Ranking4.text;
                l1Ranking4.text = l1Ranking3.text;
                l1Ranking3.text = l1Ranking2.text;
                l1Ranking2.text = l1Ranking1.text;
                l1Ranking1.text = puntuation1.ToString();
            }
            else if (l1Rankingg2 < puntuation1)
            {
                l1Ranking5.text = l1Ranking4.text;
                l1Ranking4.text = l1Ranking3.text;
                l1Ranking3.text = l1Ranking2.text;
                l1Ranking2.text = puntuation1.ToString();

            }
            else if (l1Rankingg3 < puntuation1)
            {
                l1Ranking5.text = l1Ranking4.text;
                l1Ranking4.text = l1Ranking3.text;
                l1Ranking3.text = puntuation1.ToString();
            }
            else if (l1Rankingg4 < puntuation1)
            {
                l1Ranking5.text = l1Ranking4.text;
                l1Ranking4.text = puntuation1.ToString();
            }
            else if (l1Rankingg5 < puntuation1)
            {
                l1Ranking5.text = puntuation1.ToString();
            }
        }

        private void CallL2Ranking(int puntuation2)
        {
            if (l2Rankingg1 < puntuation2)
            {
                l2Ranking5.text = l2Ranking4.text;
                l2Ranking4.text = l2Ranking3.text;
                l2Ranking3.text = l2Ranking2.text;
                l2Ranking2.text = l2Ranking1.text;
                l2Ranking1.text = puntuation2.ToString();
            }
            else if (l2Rankingg2 < puntuation2)
            { 
                l2Ranking5.text = l2Ranking4.text;
                l2Ranking4.text = l2Ranking3.text;
                l2Ranking3.text = l2Ranking2.text;
                l2Ranking2.text = puntuation2.ToString();

            }
            else if (l2Rankingg3 < puntuation2)
            {
                l2Ranking5.text = l2Ranking4.text;
                l2Ranking4.text = l2Ranking3.text;
                l2Ranking3.text = puntuation2.ToString();
            }
            else if (l2Rankingg4 < puntuation2)
            {
                l2Ranking5.text = l2Ranking4.text;
                l2Ranking4.text = puntuation2.ToString();
            }
            else if (l2Rankingg5 < puntuation2)
            {
                l2Ranking5.text = puntuation2.ToString();
            }
        }

        public void SaveRanking(string getForm, string user)
        {
            if (!System.IO.File.Exists(@"C:/UnityTestFolder/" + user + ".txt"))
            {
                System.IO.File.WriteAllText(@"C:/UnityTestFolder/" + user + ".txt", getForm);
            }
        }

        public void GetRanking(string user)
        {
            if (System.IO.File.Exists(@"C:/UnityTestFolder/" + user + ".txt")){
                File = System.IO.File.ReadAllLines(@"C:/UnityTestFolder/" + user + ".txt");
                for(int i = 0; i <= File.Length; i++)
                {
                    System.Console.WriteLine(File[i]);
                }
            }
        }

    }*/
