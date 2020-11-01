import pickle
from joblib import load

X_test = input().split()

loaded_model = load("/content/randomforestmodel1.pkl")
result = loaded_model.predict(X_test)

print(result)