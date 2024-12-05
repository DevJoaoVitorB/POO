import streamlit as st
from retangulo import Retangulo

class UIRetangulo:
    @staticmethod
    def main():
        st.header("Cálculo com Retângulos")
        b = st.text_input("Informe a Base do Retângulo: ")
        h = st.text_input("Informe a Altura do Retângulo: ")
        if st.button("Calcule Area"):
            r = Retangulo(float(b), float(h))
            st.write(f"Area = {r.calc_area()}")
        if st.button("Calcule Diagonal"):
            r = Retangulo(float(b), float(h))
            st.write(f"Diagonal = {r.calc_diagonal()}")