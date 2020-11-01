import gensim
from gensim.models import KeyedVectors

a = input()
model = KeyedVectors.load("model2.kv")
#generate similiar movies to given genre or title
def print_similiar(name):
    for node, _ in model.wv.most_similar(name):
        print(node)

print_similiar(a)