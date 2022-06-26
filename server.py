#!/usr/bin/python3
from flask import Flask, redirect, request, jsonify
import os
import cv2
import uuid
from datetime import datetime
import tensorflow as tf
flag = 0
model = tf.keras.models.load_model("CNN.model")
path = './test_images'
from flask_cors import CORS

APP_PATH = os.getcwd()
IMG_SIZE = 32
CATEGORIES = [
    'Anthony_Mackie',
    'Adriana_Lima',
    'Alex_Lawther', 
    'Alexandra_Daddario', 
    'Alvaro_Morte', 
    'alycia_dabnem_carey', 
    'Amanda_Crew', 
    'amber_heard', 
    'Andy_Samberg', 
    'Anne_Hathaway'
]
CATEGORIES_IDS = {
    'Anthony_Mackie':'290016136',
    'Adriana_Lima':'658276071',
    'Alex_Lawther':'746793862',
    'Alexandra_Daddario':'281018322', 
    'Alvaro_Morte':'943626731', 
    'alycia_dabnem_carey':'381485272',
    'Amanda_Crew':'559562754', 
    'amber_heard':'860157061', 
    'Andy_Samberg':'607770111', 
    'Anne_Hathaway':'891271606'
}
CATEGORIES_USER_IDS = {
    'Anthony_Mackie':'01',
    'Adriana_Lima':'02',
    'Alex_Lawther':'03',
    'Alexandra_Daddario':'04', 
    'Alvaro_Morte':'05', 
    'alycia_dabnem_carey':'06',
    'Amanda_Crew':'07', 
    'amber_heard':'08', 
    'Andy_Samberg':'09', 
    'Anne_Hathaway':'10'
}
ALLOWED_EXTENSIONS = {'png', 'jpg', 'jpeg', 'gif'}

allItems = {}
flag = 0
labels = {}

def prepare(file):
    img_array = cv2.imread(file)
    new_array = cv2.resize(img_array, (IMG_SIZE, IMG_SIZE)).flatten()
    return new_array.reshape(1, IMG_SIZE, IMG_SIZE, -1)

def allowed_file(filename):
    return '.' in filename and filename.rsplit('.', 1)[1].lower() in ALLOWED_EXTENSIONS
        
app = Flask(__name__)
CORS(app)

# פונקצית חיזוי באמצעות מודל
@tf.function(experimental_relax_shapes=True)
def predict(x):
    y = model(x)
    return y
        
now = datetime.now()

@app.route("/")
def index():
    return f"hello, the app started at %s" % now
        
@app.route('/detect',  methods=["GET", "POST"])
def detect():
    if request.method == "POST":
        if 'file' not in request.files:
            return redirect(request.url)
        file = request.files['file']
        if file.filename == '':
            return redirect(request.url)
        if file and allowed_file(file.filename):
            file_spl = file.filename.split(".")
            filename = f'{file_spl[0]}.{file_spl[1]}'
            filepath = f'{APP_PATH}/tmp/{filename}'
            file.save(filepath)
            try:
                if os.path.isfile(filepath):
                    image = prepare(filepath)
                    prediction = predict([image])
                    prediction = list(prediction[0])
                    label_pred = label_pred = CATEGORIES_IDS[CATEGORIES[prediction.index(max(prediction))]]
                    return jsonify({
                        "status":"seccess",
                        "file_name": f'{filename}',
                        "predict": f'{label_pred}'
                    })
            except Exception as e:
                return jsonify({"status":"Failed", "msg":e})
            
        return jsonify({
            "status":"Failed",
        })
    
if __name__ == '__main__':
    app.run(debug=True, host='0.0.0.0', port=8010)
