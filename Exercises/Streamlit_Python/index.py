import streamlit as st
from UIretangulo import UIRetangulo as UIR
from UIequacao import UIEquacao as UIE

op = st.sidebar.selectbox("Menu",["Operações com Retângulo", "Equação do 2° Grau"])
if op == "Operações com Retângulo":
    UIR.main()
if op == "Equação do 2° Grau":
    UIE.main()
