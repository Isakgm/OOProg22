using BakeryLib.Model;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BakeryLib.Repository
{
    public class BakeryRepository
    {
        private List<BakeryItem> _items;

        public BakeryRepository()
        {
            _items = new List<BakeryItem>();
        }

        public List<BakeryItem> GetAll()
        {
            return new List<BakeryItem>(_items);
        }

        public List<Bread> GetAllBread()
        {
                List<Bread> breads = new List<Bread>();
                return new List<Bread>(breads);
            
        }

        public List<Cake> GetAllCake()
        {
            
            List<Cake> cakes = new List<Cake>();
            return new List<Cake>(cakes);
        }

        public BakeryItem Add(BakeryItem bakeryItem)
        {
            int maxId = _items.Count > 0 ? _items.Max(x => x.Id) : 0;
            bakeryItem.Id = maxId + 1;
            _items.Add(bakeryItem);
            return bakeryItem;
        }

        public BakeryItem Delete(int id)
        {
            BakeryItem sletBakeryItem = GetById(id);
            _items.Remove(sletBakeryItem);
            return sletBakeryItem;
        }

        public BakeryItem GetById(int id)
        {
            BakeryItem? fundetBakeryItem = _items.Find(b => b.Id == id);
            if (fundetBakeryItem is null)
            {
                throw new KeyNotFoundException($"User with id={id} is not found");
            }

            return fundetBakeryItem;
        }

        public override string ToString()
        {
            String _tekst = "";
            foreach (BakeryItem b in _items)
            {
                _tekst += $"{b} \n\t";
            }
            return $"Bakeryitems in repository: {_tekst}";
        }
    }
}
