using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank_fraud_prevention
{
    class Program
    {
        struct data
        {
            public int order_id;
            public int deal_id;
            public string email_id;
            public string street_address;
            public string city;
            public string state;
            public int zip_code;
            public int credit_card;
        }
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            List<data> store = new List<data>(); List<int> fraud = new List<int>();
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                string[] z = s.Split(',');
                if (store.Count == 0)
                {
                    data temp;
                    int.TryParse(z[0], out temp.order_id);
                    int.TryParse(z[1], out temp.deal_id);
                    temp.email_id = truncate_email(z[2]);
                    temp.street_address = truncate_street(z[3]);
                    temp.city = truncate_city(z[4]);
                    temp.state = truncate_city(z[5]);
                    int.TryParse(z[5], out temp.zip_code);
                    int.TryParse(z[6], out temp.credit_card);
                    store.Add(temp);
                }

            }
            Console.ReadKey();
        }

        private static string truncate_city(string p)
        {
            p = p.ToLower();
            if (p == "illinois")
                p = "il";
            if (p == "canada")
                p = "ca";
            if (p == "new york")
                p = "ny";
            return p;
        }

        private static string truncate_street(string p)
        {
            p = p.ToLower();    StringBuilder s = new StringBuilder();
            if(p.EndsWith("street"))
            {
                for(int i = 0;i<p.Length-6;i++)
                {
                    s.Append(p[i]);
                }
                s.Append("st.");
            }
            if (p.EndsWith("road"))
            {
                for (int i = 0; i < p.Length - 4; i++)
                {
                    s.Append(p[i]);
                }
                s.Append("rd.");
            }
            Console.WriteLine(s);
            return s.ToString();

        }

        private static string truncate_email(string p)
        {
            bool do_not_copy = false;
            StringBuilder emailtemp = new StringBuilder(); p = p.ToLower(); int i;
            for (i = 0; p[i] != '@'; i++)
            {
                if (p[i] == '.')
                    continue;
                if (p[i] == '+')
                    do_not_copy = true;
                if(!do_not_copy)
                    emailtemp.Append(p[i]);
            }
            for (; i < p.Length; i++)
                emailtemp.Append(p[i]);
            //Console.WriteLine(emailtemp);
            return emailtemp.ToString();
        }
    }
}
