import 'bootstrap/dist/css/bootstrap.css';
import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter } from 'react-router-dom';
import App from './App';
import registerServiceWorker from './registerServiceWorker';
import { initialState } from './contexto/initialState';
import { StateProvider } from './contexto/store';
import { mainReducer } from './contexto/reducers/index';


const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href');
const rootElement = document.getElementById('root');

ReactDOM.render(
    <BrowserRouter basename={baseUrl}>
        <StateProvider initialState={initialState} reducer={mainReducer}>
            <App />
        </StateProvider>
  </BrowserRouter>,
  rootElement);

registerServiceWorker();

