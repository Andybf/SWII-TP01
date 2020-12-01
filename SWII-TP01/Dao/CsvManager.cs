using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SWII_TP01.Dao {
    class CsvManager {

        private List<Model.Book> listOfBooks;

        private StreamReader bookFile;
        private StreamReader authorsFile;

        public CsvManager() {
            this.bookFile = new StreamReader("books.csv");
            this.authorsFile = new StreamReader("C:\\Users\\Anderson Bucchianico\\source\\repos\\SWII-TP01\\SWII-TP01\\repositorio\\authors.csv");

            String lineBuffer = this.authorsFile.ReadLine();
            //Console.WriteLine(lineBuffer);
            String[] objectBuffer = lineBuffer.Split(';');
            //Console.WriteLine(objectBuffer);



            //listOfBooks.Add();
            //Model.Author a = new Model.Author(String name, String email, char gender);
    }

        public void Insert(Model.Book b) {
            String authorBuffer = new String("");
            foreach (Model.Author author in b.getAuthors()) {
                authorBuffer += author.getId()+";"+author.getName() + ";" + author.getEmail() + ";" + author.getGender() + ";" + b.getId() + "\n";
            }
            //authorsFile.Write(Encoding.UTF8.GetBytes(authorBuffer));

            String bookBuffer = b.getId()+";"+b.getName()+";"+b.getPrice()+";"+b.getQuantity() + "\n";
            //bookFile.Write(Encoding.UTF8.GetBytes(bookBuffer));
        }

        public void Update(Model.Book book) {
            //foreach () { 
            
            //}
        }

        public Boolean Delete(Model.Book book) {
            return false;
        }

        public Model.Book GetByName(String searchBookName) {
            foreach (Model.Book book in this.listOfBooks) {
                if (book.getName().Equals(searchBookName)) {
                    return book;
                }
            }
            return null;
        }
    }
}
