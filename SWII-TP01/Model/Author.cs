using System;
using System.Collections.Generic;
using System.Text;

namespace SWII_TP01.Model {
    class Author {

        private int id;
        private String name;
        private String email;
        private char gender;

        public Author() {
        }

        public Author(String name, String email, char gender) {
            this.name = name;
            this.email = email;
            this.gender = gender;
        }

        public int getId() {
            return this.id;
        }
        public String getName() {
            return this.name;
        }
        public String getEmail() {
            return this.email;
        }
        public char getGender() {
            return this.gender;
        }
    }
}
