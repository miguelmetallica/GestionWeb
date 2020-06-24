import React from 'react';
import { ThemeProvider as MuithemeProvider} from "@material-ui/core/styles";
import theme from "./theme/theme";
import RegistrarUsuario from './components/seguridad/RegistrarUsuario';

//import { Route } from 'react-router';
//import { Layout } from './components/Layout';
//import { Home } from './components/Home';
//import { FetchData } from './components/FetchData';
//import { Counter } from './components/Counter';

//import './custom.css'

function App()
{
    return(
        <MuithemeProvider theme={theme}>
            <RegistrarUsuario/>            
        </MuithemeProvider>
        )
}

export default App;