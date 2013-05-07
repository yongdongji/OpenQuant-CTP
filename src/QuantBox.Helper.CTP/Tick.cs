﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuantBox.Helper.CTP
{
    public class Tick
    {
        public Tick()
        {
        }

        public Tick(string Symbol,
            double Price, int Size)
        {
            this.Symbol = Symbol;
            this.Price = Price;
            this.Bid = double.NaN;
            this.BidSize = 0;
            this.Ask = double.NaN;
            this.AskSize = 0;
        }

        public Tick(string Symbol,
            double Bid, int BidSize,
            double Ask, int AskSize)
        {
            this.Symbol = Symbol;
            this.Price = double.NaN;
            this.Size = 0;
            this.Bid = Bid;
            this.BidSize = BidSize;
            this.Ask = Ask;
            this.AskSize = AskSize;
        }

        public Tick(string Symbol,
            double Price,int Size,
            double Bid,int BidSize,
            double Ask,int AskSize)
        {
            this.Symbol = Symbol;
            this.Price = Price;
            this.Size = Size;
            this.Bid = Bid;
            this.BidSize = BidSize;
            this.Ask = Ask;
            this.AskSize = AskSize;
        }

        public string Symbol;
        public double Price;
        public int Size;
        public double Bid;
        public int BidSize;
        public double Ask;
        public int AskSize;
    }
}
