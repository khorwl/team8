import React from "react";
import styles from './styles.css'
import joker from './images/card-joker.png'

export default class Cell extends React.Component {
    constructor(props) {
        super(props);
        this.id = props.id
    }

    render() {
        console.log(`${joker}`);
        return (<td className={styles.cell}>
            <div className={styles.card} id="demo" style={{
                backgroundImage: `url(${joker})`,
                backgroundSize: 'contain'
            }}>
                <div className={[styles.cardSide, styles.cardBack]} />
                <div className={[styles.cardSide, styles.cardFace]}/>
            </div>
        </td>);
    }
}