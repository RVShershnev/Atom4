import pickle
from joblib import load

X_test = [[8, 0, 20]]

loaded_model = load("randomforestmodel1.pkl")
result = loaded_model.predict(X_test)

print(result)