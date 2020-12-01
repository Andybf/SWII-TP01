using System;
using System.Collections.Generic;
using System.Text;

namespace SWII_TP01.Model {
    class Book {

        private int id;
        private String name;
        private List<Author> author;
        private double price;
        private int quantity;

        public Book(String name, Author[] authors, double price) {

        }

        public Book(String name, Author[] authors, double price, int quantity) {

        }

        public int getId() {
            return this.id;
        }
        public String getName() {
            return this.name;
        }

        public Author[] getAuthors() {
            return null;
        }

        public double getPrice() {
            return this.price;
        }

        public void setPrice(double price) {
            this.price = price;
        }

        public int getQuantity() {
            return this.quantity;
        }

        public String toString() {
            return "Book[name=,authors={Author[name=,email=,gender],price=,quantity}]";
        }

        public String getAuthorNames() {
            return "1,2";
        }
    }

    
}
