import streamlit as st
import pandas as pd
from equacao import Equacao

class UIEquacao:
    @staticmethod
    def main():
        st.header("Cálculo de Equação do 2º Grau")
        a = st.text_input("Informe o Valor de a: ")
        b = st.text_input("Informe o Valor de b: ")
        c = st.text_input("Informe o Valor de c: ")
        pontos = st.text_input("Quantidade de Pontos do Gráfico: ")

        if st.button("Calcular"):
            e = Equacao(int(a), int(b), int(c))
            st.write(e.__str__())

            st.write(f"Delta = {e.delta()}")
            st.write(f"X1 = {e.x1()}")
            st.write(f"X2 = {e.x2()}")

            # px = [] # Coordenadas X
            # py = [] # Coordenadas Y

            # if e.delta() > 0:
            #     x1 = e.x1() # Menor Raiz
            #     x2 = e.x2() # Maior Raiz
            #     d = x2 - x1
            #     xmin = x1 - d/2         # Limite Inferior do Gráfico
            #     xmax = x2 - d/2         # Limite Superior do Gráfico
            # if e.delta() == 0:
            #     xmin = 0.5 * x1 - 1     # Limite Inferior do Gráfico
            #     xmax = 1.5 * x1 + 1     # Limite Superior do Gráfico
            # if e.delta() < 0:
            #     xmin = 0.5 * e.xplano() # Limite Inferior do Gráfico
            #     xmin = 1.5 * e.xplano() # Limite Superior do Gráfico
            
            # if xmin == 0 or xmax == 0:
            #     xmin = -5
            #     xmax = 5

            # pontos = int(pontos)
            # d = (xmax - xmin)/pontos
            # x = xmin

            # while x <= xmax:
            #     px.append(x)
            #     py.append(e.y(x))
            #     x += d
            # px.append(x)
            # py.append(e.y(xmax))

            # dic = {"x":px, "y":py}
            # dataframe = pd.DataFrame(dic)
            # st.line_chart(dataframe, x = "x", y = "y")
