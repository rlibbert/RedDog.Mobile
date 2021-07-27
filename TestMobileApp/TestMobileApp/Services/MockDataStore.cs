using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TestMobileApp.Models;

namespace TestMobileApp.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        //public MockDataStore()
        //{
        //    try
        //    {
        //        // Create an instance of StreamReader to read from a file.
        //        // The using statement also closes the StreamReader.
        //        using (StreamReader sr = new StreamReader("/Users/rl/items.txt"))
        //        {
        //            string line;
        //            // Read and display lines from the file until the end of
        //            // the file is reached.
        //            while ((line = sr.ReadLine()) != null)
        //            {
        //                Console.WriteLine(line);
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        // Let the user know what went wrong.
        //        Console.WriteLine("The file could not be read:");
        //        Console.WriteLine(e.Message);
        //    }
        //}


        public MockDataStore()

        {
            items = new List<Item>()

            {
                //new Item { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description.", UnitPrice="5.47" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Omeprazole_Cap E / C 10mg", Description="No Description",  UnitPrice="13.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Dressit Ster Dress Pack", Description="No Description",  UnitPrice="4.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Flaminal Forte 15g Tube Wound Dress Prot", Description="No Description",  UnitPrice="10.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Co-Magaldrox_Susp 195mg / 220mg / 5ml S / F", Description="No Description",  UnitPrice="11.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Antacid / Oxetacaine_Oral Susp S / F", Description="No Description",  UnitPrice="3.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Simeticone_Susp 40mg / ml S / F", Description="No Description",  UnitPrice="10.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Infacol_Susp 40mg / ml S / F", Description="No Description",  UnitPrice="6.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Gppe Liq_Gaviscon S / F", Description="No Description",  UnitPrice="2.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Sod Algin / Pot Bicarb_Susp S / F", Description="No Description",  UnitPrice="10.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Sod Alginate / Pot Bicarb_Tab Chble 500mg", Description="No Description",  UnitPrice="15.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Gastrocote_Tab", Description="No Description",  UnitPrice="6.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Gaviscon Infant_Sach 2g (Dual Pack) S / F", Description="No Description",  UnitPrice="8.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Gaviscon Advance_Liq (Aniseed) S / F", Description="No Description",  UnitPrice="7.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Gaviscon_Liq Sach 10ml (Peppermint) S / F", Description="No Description",  UnitPrice="8.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Gaviscon Advance_Liq (Peppermint) S / F", Description="No Description",  UnitPrice="14.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Gaviscon Advance_Tab Chble 500mg Mint", Description="No Description",  UnitPrice="2.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Gaviscon Double Action_Tab Chble", Description="No Description",  UnitPrice="4.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Topal_Antacid Tab", Description="No Description",  UnitPrice="12.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Peptac_Liq (Aniseed) S / F", Description="No Description",  UnitPrice="10.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Peptac_Liq (Peppermint) S / F", Description="No Description",  UnitPrice="12.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Alverine Cit_Cap 60mg", Description="No Description",  UnitPrice="17.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Dicycloverine HCl_Tab 10mg", Description="No Description",  UnitPrice="10.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Dicycloverine HCl_Tab 20mg", Description="No Description",  UnitPrice="5.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Hyoscine Butylbrom_Inj 20mg / ml 1ml Amp", Description="No Description",  UnitPrice="8.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Hyoscine Butylbrom_Tab 10mg", Description="No Description",  UnitPrice="7.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Buscopan_Tab 10mg", Description="No Description",  UnitPrice="3.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Mebeverine HCl_Tab 135mg", Description="No Description",  UnitPrice="7.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Mebeverine HCl_Cap 200mg M / R", Description="No Description",  UnitPrice="17.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Colofac_Tab 135mg", Description="No Description",  UnitPrice="16.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Peppermint Oil_Cap E / C 0.2ml", Description="No Description",  UnitPrice="11.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Peppermint Oil_Cap E / C 0.2ml M / R", Description="No Description",  UnitPrice="16.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Colpermin_Cap E / C 0.2ml M / R", Description="No Description",  UnitPrice="10.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Cimetidine_Tab 200mg", Description="No Description",  UnitPrice="12.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Cimetidine_Tab 400mg", Description="No Description",  UnitPrice="15.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Tagamet_Tab 400mg", Description="No Description",  UnitPrice="9.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Ranitidine HCl_Tab 150mg", Description="No Description",  UnitPrice="13.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Ranitidine HCl_Tab 300mg", Description="No Description",  UnitPrice="11.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Ranitidine HCl_Oral Soln 75mg / 5ml S / F", Description="No Description",  UnitPrice="16.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Ranitidine HCl_Tab Eff 150mg", Description="No Description",  UnitPrice="9.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Sucralfate_Tab 1g", Description="No Description",  UnitPrice="2.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Esomeprazole_Tab E / C 20mg", Description="No Description",  UnitPrice="17.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Esomeprazole_Tab E / C 40mg", Description="No Description",  UnitPrice="3.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Lansoprazole_Cap 30mg (E / C Gran)", Description="No Description",  UnitPrice="5.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Lansoprazole_Cap 15mg (E / C Gran)", Description="No Description",  UnitPrice="4.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Lansoprazole_Orodisper Tab 15mg", Description="No Description",  UnitPrice="3.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Lansoprazole_Orodisper Tab 30mg", Description="No Description",  UnitPrice="15.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Omeprazole_Cap E / C 20mg", Description="No Description",  UnitPrice="15.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Omeprazole_Cap E / C 40mg", Description="No Description",  UnitPrice="8.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Omeprazole_Tab Disper 20mg (E / C Pellets)", Description="No Description",  UnitPrice="3.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Omeprazole_Tab Disper 40mg (E / C Pellets)", Description="No Description",  UnitPrice="10.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Omeprazole_Tab E / C 20mg", Description="No Description",  UnitPrice="13.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Omeprazole_Tab E / C 40mg", Description="No Description",  UnitPrice="3.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Omeprazole_Oral Susp 20mg / 5ml", Description="No Description",  UnitPrice="13.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Losec_Cap E / C 20mg", Description="No Description",  UnitPrice="8.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Pantoprazole_Tab E / C 40mg", Description="No Description",  UnitPrice="2.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Pantoprazole_Tab E / C 20mg", Description="No Description",  UnitPrice="8.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Rabeprazole Sod_Tab E / C 10mg", Description="No Description",  UnitPrice="3.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Rabeprazole Sod_Tab E / C 20mg", Description="No Description",  UnitPrice="13.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Co-Phenotrope_Tab 2.5mg / 25mcg", Description="No Description",  UnitPrice="9.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Loperamide HCl_Cap 2mg", Description="No Description",  UnitPrice="12.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Loperamide HCl_Oral Soln 1mg / 5ml S / F", Description="No Description",  UnitPrice="4.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "​​Imodium Instants_Tab 2mg", Description="No Description",  UnitPrice="9.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Asacol_MR Tab E / C 400mg", Description="No Description",  UnitPrice="7.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Pentasa SR_Tab 500mg", Description="No Description",  UnitPrice="16.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Pentasa_Tab 1g M / R", Description="No Description",  UnitPrice="8.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Balsalazide Sod_Cap 750mg", Description="No Description",  UnitPrice="14.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Sulfasalazine_Tab 500mg", Description="No Description",  UnitPrice="3.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Sulfasalazine_Tab E / C 500mg", Description="No Description",  UnitPrice="2.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Salazopyrin-En_Tab 500mg", Description="No Description",  UnitPrice="12.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Budesonide_Cap 3mg (E / C Pellets)", Description="No Description",  UnitPrice="12.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Entocort CR_Cap 3mg (E / CM / R Gran)", Description="No Description",  UnitPrice="18.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Hydrocort Acet_Foam Aero Enem 10% (14 D)", Description="No Description",  UnitPrice="16.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Colifoam_Foam Aero Enem 10% 20.8g (14 D)", Description="No Description",  UnitPrice="3.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Sod Cromoglicate_Cap 100mg", Description="No Description",  UnitPrice="13.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Ispag Husk_Gran Eff Sach 3.5g S / F", Description="No Description",  UnitPrice="17.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Ispag Husk_Pdr Sach 3.4g Orange S / F", Description="No Description",  UnitPrice="4.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Ispag Husk_Gran Sach 3.5g G / F", Description="No Description",  UnitPrice="18.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Ispag Husk_Gran Sach 3.5g G / FS / F", Description="No Description",  UnitPrice="12.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Fybogel_Gran Sach 3.5g Orange G / FS / F", Description="No Description",  UnitPrice="6.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Methylcellulose_Tab 500mg", Description="No Description",  UnitPrice="16.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Co-Danthramer_Susp 25mg / 200mg / 5ml S / F", Description="No Description",  UnitPrice="16.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Co-Danthramer_Cap Strong 37.5mg / 500mg", Description="No Description",  UnitPrice="12.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Bisacodyl_Tab E / C 5mg", Description="No Description",  UnitPrice="6.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Bisacodyl_Suppos 10mg", Description="No Description",  UnitPrice="9.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Docusate Sod_Oral Soln 50mg / 5ml S / F", Description="No Description",  UnitPrice="17.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Docusate Sod_Cap 100mg", Description="No Description",  UnitPrice="12.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Co-Danthrusate_Cap 50mg / 60mg", Description="No Description",  UnitPrice="15.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Glycerol_Suppos Adult's (4g)", Description="No Description",  UnitPrice="3.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Senna_Tab 7.5mg", Description="No Description",  UnitPrice="7.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Ispaghula / Senna Fruit_Gran 54.2% / 12.4%", Description="No Description",  UnitPrice="9.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Senna_Oral Soln 7.5mg / 5ml S / F", Description="No Description",  UnitPrice="6.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Manevac_Gran", Description="No Description",  UnitPrice="15.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Sod Picosulf_Oral Soln 5mg / 5ml S / F", Description="No Description",  UnitPrice="3.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Sod Picosulf_Cap 2.5mg", Description="No Description",  UnitPrice="2.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Lactulose_Soln 3.1g-3.7g / 5ml", Description="No Description",  UnitPrice="18.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Macrogol_Co Oral Pdr Sach S / F", Description="No Description",  UnitPrice="14.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Movicol_Pdr Sach 13.8g (Lem & Lim)", Description="No Description",  UnitPrice="6.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Movicol Plain_Paed Pdr Sach 6.9g", Description="No Description",  UnitPrice="13.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Laxido_Oral Pdr Sach (Orange)", Description="No Description",  UnitPrice="4.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Laxido_Oral Pdr Sach (Orange) S / F", Description="No Description",  UnitPrice="11.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Phos Enem_ (For B) 128ml Stnd Tube", Description="No Description",  UnitPrice="3.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Micralax_Micro-Enem 5ml", Description="No Description",  UnitPrice="9.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Picolax_Pdr Sach 16.3g", Description="No Description",  UnitPrice="5.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Diltiazem HCl_Crm 2%", Description="No Description",  UnitPrice="15.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Anusol_Crm", Description="No Description",  UnitPrice="9.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Anusol_Oint", Description="No Description",  UnitPrice="10.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Anusol_Suppos", Description="No Description",  UnitPrice="6.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Ultraproct_Oint", Description="No Description",  UnitPrice="7.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Ultraproct_Suppos", Description="No Description",  UnitPrice="13.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Cinchocaine HCl / Hydrocort_Oint 0.5% / 0.5%", Description="No Description",  UnitPrice="3.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Cinchocaine HCl / Hydrocort_Suppos 5mg / 5mg", Description="No Description",  UnitPrice="7.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Lido / Hydrocort Acet_Oint 5% / 0.275%", Description="No Description",  UnitPrice="11.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Anugesic HC_Crm", Description="No Description",  UnitPrice="5.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Anugesic HC_Suppos", Description="No Description",  UnitPrice="7.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Anusol HC_Suppos", Description="No Description",  UnitPrice="10.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Anusol HC_Oint", Description="No Description",  UnitPrice="14.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Xyloproct_Oint 5% / 0.275%", Description="No Description",  UnitPrice="8.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Cinchocaine / Prednisolone_Oint 0.5% / 0.19%", Description="No Description",  UnitPrice="13.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Scheriproct_Oint", Description="No Description",  UnitPrice="15.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Glyceryl Trinit_Oint 0.4%", Description="No Description",  UnitPrice="4.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Ursodeoxycholic Acid_Tab 150mg", Description="No Description",  UnitPrice="14.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Ursodeoxycholic Acid_Cap 250mg", Description="No Description",  UnitPrice="7.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Ursodeoxycholic Acid_Tab 300mg", Description="No Description",  UnitPrice="2.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Creon 25000_Cap E / C", Description="No Description",  UnitPrice="10.99" },
                new Item {Id = Guid.NewGuid().ToString(), Text = "Creon 10000_Cap E / C", Description="No Description",  UnitPrice="14.99" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." }
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}